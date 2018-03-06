using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;
using System.Threading;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class ThreadParam
    {
        public Object obj;
        public Object to;
        public int id;
        public MoviesController mctrl;
        public ManualResetEvent eventX = new ManualResetEvent(false);
    }
    public class MoviesController : Controller
    {
        private MovieDBContext db = new MovieDBContext();
        private MemcachedService ms = MemcachedService.GetInstance("test");
        private delegate int DGtestMethod(int tm, MoviesController ctl);
        private DGtestMethod dgg = new DGtestMethod(testMethodDelegate);

        private async Task DoWork()
        {
                await Task.Delay(1000);//以前我们用Thread.Sleep(1000)，这是它的替代方式。 
        }
        private async Task example1()
        {
            await DoWork();
        }
        private async Task GetTag(ThreadParam p)
        {
             await asynctask(p);
        }
        private async Task asynctask(ThreadParam p)
        {
            //return await Task.Run(() => {
                MovieDBContext tmpdb = new MovieDBContext();
                p.to = tmpdb.Movies.ToList();
                tmpdb.Dispose();
                ViewBag.asyncThreadid2 = Thread.CurrentThread.ManagedThreadId;
                await Task.Delay(100);
               // return 0;
           // });
        }
        private void testMethod(int tm)
        {
            int tmp = 1;
            for (int i = 0; i < tm*1000; i++)
            {
                Random rnd = new Random();
                int rd = rnd.Next(1, 1000);
                tmp = (tmp * rd) % 999999999;
            }
            ViewBag.asyncThreadid1 = Thread.CurrentThread.ManagedThreadId;
        }

        private static int testMethodDelegate(int tm, MoviesController ctl)
        {
            if(!ctl.ms.mClient.KeyExists("xxxxxx2"))
            {
                MovieDBContext tmpdb = new MovieDBContext();
                Movie mv = tmpdb.Movies.Find(6);
                tmpdb.Dispose();
            }
            
            int tmp = 1;
            for (int i = 0; i < tm * 1000; i++)
            {
                Random rnd = new Random();
                int rd = rnd.Next(1, 1000);
                tmp = (tmp * rd) % 999999999;
            }
            ctl.ViewBag.asyncThreadid2 = Thread.CurrentThread.ManagedThreadId;
            return tmp;
        }

        private  void testMethodDelegateFinished(IAsyncResult result)
        {
            int re = dgg.EndInvoke(result);
            for (int i = 0; i < re; i++)
                i = (i + re) / 2;
            ViewBag.asyncThreadid3 = Thread.CurrentThread.ManagedThreadId;
        }
        private void testThreadMethod( Object tm2)
        {
            ThreadParam tp = tm2 as ThreadParam;
            if (!tp.mctrl.ms.mClient.KeyExists("xxxxxx2"))
            {
                //MovieDBContext tmpdb = new MovieDBContext();
                //Movie mv = tmpdb.Movies.Find(7);
                //tmpdb.Dispose();
            }
            int tm = (int)tp.obj;
            int tmp = 1;
            for (int i = 0; i < tm * 1000; i++)
            {
                Random rnd = new Random();
                int rd = rnd.Next(1, 1000);
                tmp = (tmp * rd) % 999999999;
            }
            tp.mctrl.ViewBag.asyncThreadid2 = Thread.CurrentThread.ManagedThreadId;
            

            tp.to = db.Movies.Find(tp.id);

            tp.eventX.Set();
        }

        private void testTaskMethod(Object tm2)
        {
            ThreadParam tp = tm2 as ThreadParam;
            if (!tp.mctrl.ms.mClient.KeyExists("xxxxxx2"))
            {
                //MovieDBContext tmpdb = new MovieDBContext();
                //Movie mv = tp.mctrl.db.Movies.Find(8);
                //tmpdb.Dispose();
            }
            int tm = (int)tp.obj;
            int tmp = 1;
            for (int i = 0; i < tm * 1000; i++)
            {
                Random rnd = new Random();
                int rd = rnd.Next(1, 1000);
                tmp = (tmp * rd) % 999999999;
            }
            tp.mctrl.ViewBag.asyncThreadid2 = Thread.CurrentThread.ManagedThreadId;
            tp.to = db.Movies.Find(tp.id);
        }

        // GET: Movies
        public ActionResult Index()
        {
            Random rnd = new Random();
            int rd = rnd.Next(1, 1000);
            testMethod(rd);
            ThreadParam tp = new ThreadParam();
            Task t = example1();
            t.Wait();
            //dgg(rd, this);
            return View(tp.to);
        }

        // GET: Movies/Details/5
        public ActionResult Details(int? id)
        {
            ParameterizedThreadStart start = new ParameterizedThreadStart(testThreadMethod);
            Thread thread = new Thread(start);
            ThreadParam tp = new ThreadParam();
            Random rnd = new Random();
            int rd = rnd.Next(1, 1000);
            tp.obj = rd;
            tp.mctrl = this;

           

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //Movie movie = null;
            //tp.to = movie;
            tp.id = (int)id;
            thread.Start(tp);
            //Movie movie = db.Movies.Find(id);
            
           
            testMethod(rd);
           
            thread.Join();
            Movie movie =(Movie) tp.to;
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            
            Random rnd = new Random();
            int rd = rnd.Next(1, 1000);
            IAsyncResult ir = dgg.BeginInvoke(rd, this, new AsyncCallback(testMethodDelegateFinished), null);
            testMethod(rd);
           
            ir.AsyncWaitHandle.WaitOne();
            return View();
        }

        // POST: Movies/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,ReleaseDate,Genre,Price")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                string key = movie.Title.Replace(" ", "");
                if (!ms.mClient.KeyExists(key))
                {
                    string value = movie.ReleaseDate + movie.Genre + movie.Price ;
                    bool ret = ms.mClient.Set(key, value);
                    //string value2 = ms.mClient.Get(key) as string;
                    db.Movies.Add(movie);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                    ViewBag.errmsg = movie.Title + " 同名电影已经存在，请改名";
               // db.Movies.Add(movie);
               // db.SaveChanges();
               // return RedirectToAction("Index");
            }

            return View(movie);
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int? id)
        {
            Random rnd = new Random();
            int rd = rnd.Next(1, 1000);
            //
            WaitCallback w = new WaitCallback(testThreadMethod);
            ThreadParam tp = new ThreadParam();
            tp.obj = rd;
            tp.mctrl = this;
            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            tp.id = (int)id;
            ThreadPool.QueueUserWorkItem(w, tp);
            testMethod(rd);
            //Movie movie = db.Movies.Find(id);
            tp.eventX.WaitOne();
            Movie movie = (Movie) tp.to;
            if (movie == null)
            {
                return HttpNotFound();
            }
            
            return View(movie);
        }

        // POST: Movies/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,ReleaseDate,Genre,Price")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int? id)
        {
            Random rnd = new Random();
            int rd = rnd.Next(1, 1000);
            
            ThreadParam tp = new ThreadParam();
            tp.obj = rd;
            tp.mctrl = this;
            Task t1 = new Task(testTaskMethod, tp);
            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tp.id = (int) id;
            t1.Start();
            testMethod(rd);
            
           // Movie movie = db.Movies.Find(id);
            t1.Wait();
            Movie movie = (Movie)tp.to;
            if (movie == null)
            {
                return HttpNotFound();
            }
           
            
            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movie = db.Movies.Find(id);
            string key = movie.Title.Replace(" ","");
            if (ms.mClient.KeyExists(key))
            {
                ms.mClient.Delete(key);
            }
            
            db.Movies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            //Random rnd = new Random();
            //int rd = rnd.Next(1, 1000);
            //testMethod(rd);
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
