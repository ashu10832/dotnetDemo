using System;
using entity_demo.Model;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace entity_demo
{

    class StudentDAO
    {
        public void insertIntoStud(Stud stud){
            try
            {
                studentContext context = new studentContext();
                context.Stud.Add(stud);
                context.SaveChanges();
            }
            catch (System.Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void getAllStudents(){
            try
            {
                using (var db = new studentContext())
                {
                    foreach (var item in db.Stud)
                    {
                        System.Console.WriteLine(item.Sid + item.Fname + item.Dob);
                    }

                }                
            }
            catch (System.Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public  List<Stud> getAllStudentsList(){
            List<Stud> studentE;
            try
            {
                using (var db = new studentContext())
                {
                    IQueryable<Stud> en = from obj in db.Stud
                                select obj;
                    studentE = en.ToList();
                }
            }
            catch (System.Exception e)
            {
                
                throw e;
            }
            return studentE;
        }

        public  List<Stud> getAllStudentsList(string sid){
            List<Stud> studentE;
            try
            {
                using (var db = new studentContext())
                {
                    IQueryable<Stud> en = from obj in db.Stud
                                where obj.Sid==sid
                                select obj;
                    studentE = en.ToList();
                }
            }
            catch (System.Exception e)
            {
                
                throw e;
            }
            return studentE;
        }


        public void updateStudent(Stud student){
            try
            {
                using (var db = new studentContext())
                {
                    var std = db.Stud.First(x => x.Sid == student.Sid );
                    std.Fname=student.Fname;
                    db.SaveChanges();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void deleteStudent(Stud student){
            try
            {
                using (var db = new studentContext())
                {
                    var std = db.Stud.First(x => x.Sid == student.Sid );
                    db.Stud.Remove(std);
                    db.SaveChanges();
                }
            }
            catch (System.Exception)
            {
                throw;
            }

        }


    }
    
}