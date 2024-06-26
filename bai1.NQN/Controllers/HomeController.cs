﻿using bai1.NQN.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Xml.Linq;

namespace bai1.NQN.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult TestViewResult()
        { return View(); }
        public PartialViewResult TestPartialViewResult ()
        {
            return PartialView();
        }
        public EmptyResult TestEmptyResult ()
        {
            return new EmptyResult();
        }
        public RedirectResult TestRedirectResult()
        {
            return Redirect("Index");

        }
        public JsonResult TestJsonResult()
        {
            List<Student> listStudent = new List<Student>();
            listStudent.Add(new Student()
            {
                 Id = 001,
                Name = "Nguyễn Quang Huy", ClassName = "C1311L" });
            listStudent.Add(new Student()
           
            {
                Id = 001,
                Name = "Nguyễn Quang Huy", ClassName = "C1311J" });
            listStudent.Add(new Student()
            
            {
                Id = 001,
                Name = "Nguyễn Quang Hiển", ClassName = "C1311H" });
            listStudent.Add(new Student()
           
            {
                Id = 001,
                Name = "Nguyễn Duy Huân", ClassName = "C1311T" });
            listStudent.Add(new Student()
            
            {
                Id = 001,
                Name = "Vũ Quang Huy", ClassName = "C1311C" });
            listStudent.Add(new Student()
           
            {
                Id = 001,
                Name = "Trần Quang  Huy", ClassName = "C1311L" });
            listStudent.Add(new Student()
          
            {
                Id = 001,
                Name = "Phạm Quang Huy", ClassName = "C1311L" });
            listStudent.Add(new Student()
           
            {
                Id = 001,
                Name = "Trịnh Quang Huy", ClassName = "C1311B" });
            listStudent.Add(new Student()
           
            {
                Id = 001,
                Name = "Vũ Quang Huy", ClassName = "C1311L" });
            listStudent.Add(new Student()

            {
                Id = 001,
                Name = "Vũ MinhTrịnh", ClassName = "C1311M" });
            return Json(listStudent, JsonRequestBehavior.AllowGet);
            }
        public JavaScriptResult TestJavaScriptResult()
        {
            string js = "funtion checkEMail(){var btloc=/^([w-]+(?:.[w-]+)*)@((?: [w -] +.) * w[w -]{ 0,66}).([a - z]{ 2,6} (?:.[a - z]{ 2})?)$/ iif (btloc.test(mail)) { kq = true; }else{                alert(“Email address invalid”);    kq = false;}return kq;}";
            return JavaScript(js);
        }
        public ContentResult TestContentResult()
        {
            XElement contentXML = new XElement("Students",
            new XElement("Student",
            new XElement("ID", "001"),
            new XElement("FullName", "Nguyễn Viết Nam"),
            new XElement("ClassName", "C1308H")),
            new XElement("Student",
            new XElement("ID", "002"),
            new XElement("FullName", "Nguyễn Hoàng Anh"),
            new XElement("ClassName", "C1411P")),
            new XElement("Student",
            new XElement("ID", "003"),
            new XElement("FullName", "Phạm Ngọc Anh"),
            new XElement("ClassName", "C1411L")),
            new XElement("Student",
            new XElement("ID", "004"),
            new XElement("FullName", "Trần Ngọc Linh"),
            new XElement("ClassName", "C1411H")),
            new XElement("Student",
            new XElement("ID", "005"),
            new XElement("FullName", "Nguyễn Hồng Anh"),
            new XElement("ClassName", "C1411L")));
            return Content(contentXML.ToString(), "text/xml",
            Encoding.UTF8);
        }
        public FileContentResult TestFileContentResult()
        {
            byte[] fileBytes =
            System.IO.File.ReadAllBytes(Server.MapPath("~/Content/demovideo.mp4"));
            string fileName = "demovideo.mp4";
            return File(fileBytes, "video/mp4", fileName);
        }
        public FileStreamResult TestFileStreamResult()
        {
            string pathFile = Server.MapPath("~/Content/vonsong.docx");
            string fileName = "vonsong.docx";
            return File(new FileStream(pathFile, FileMode.Open),
            "text/doc", fileName);
        }
        public FilePathResult TestFilePathResult()
        {
            string pathFile = Server.MapPath("~/Content/vonsong.docx");
            string fileName = "vonsong.docx";
            return File(pathFile, "text/doc", fileName);
        }
    }
}