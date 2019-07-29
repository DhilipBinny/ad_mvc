using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demo1.Models
{
    public class temp
    {
        //// GET: Employee
        //public ActionResult Index(string id)
        //{
        //    Employee user = (Employee)Session["user"];
        //    ViewData["userobj"] = user;
        //    return View();
        //}

        //public ActionResult newrequest()
        //{
        //    employee_utility eu = new employee_utility();
        //    Employee user = (Employee)Session["user"];

        //    eu.delete_temp_request_forms();

        //    Employee emp = eu.get_employee(user);
        //    DepartmentList dept = eu.get_department(user);
        //    List<StationeryCatalog> items = eu.get_catalog_items();

        //    string form_number = eu.get_form_no();
        //    eu.add_newrequestform(form_number, emp);

        //    //Employee user = (Employee)Session["user"];        
        //    //Employee emp;
        //    //DepartmentList dept;
        //    //List<StationeryCatalog> items;
        //    //string form_number;

        //    //using (stationeryEntities1 db = new stationeryEntities1())
        //    //{
        //    //    db.RequisitionForms.RemoveRange(db.RequisitionForms.Where(x => x.Status == "temp_pending").ToList());
        //    //    db.SaveChanges();
        //    //}

        //    //using (stationeryEntities1 db = new stationeryEntities1())
        //    //{
        //    //    emp = db.Employees.Find(user.Id);
        //    //    dept = db.DepartmentLists.Find(user.DepartmentCode);
        //    //    items = db.StationeryCatalogs.ToList();

        //    //    form_number = db.RequisitionForms.Max(p => p.FormNumber);
        //    //    form_number = (Convert.ToInt32(form_number)+1).ToString();

        //    //    db.RequisitionForms.Add(new RequisitionForm { FormNumber = form_number, EmployeeId = emp.Id, Status = "temp_pending" });
        //    //    db.SaveChanges();
        //    //}

        //    ViewData["catalog_list"] = items;
        //    ViewData["emp"] = emp;
        //    ViewData["emp_dept"] = dept;
        //    ViewData["form_number"] = form_number;
        //    return View();
        //}

        //public ActionResult viewrequest(string id)
        //{
        //    employee_utility eu = new employee_utility();
        //    Employee user = (Employee)Session["user"];
        //    List<RequisitionForm> reqfrorms = eu.get_req_forms(user);
        //    //List<RequisitionForm> reqfrorms;
        //    //using(stationeryEntities1 db = new stationeryEntities1())
        //    //{
        //    //    reqfrorms = db.RequisitionForms.Where(x=>x.EmployeeId==user.Id&& x.Status!="temp_pending").ToList();
        //    //}
        //    ViewData["userobj"] = user;
        //    ViewData["requestlist"] = reqfrorms;
        //    return View();
        //}

        //public ActionResult addnew(RequisitionFormDetail form_detail_obj)
        //{
        //    employee_utility eu = new employee_utility();
        //    eu.add_new_form_detail_row(form_detail_obj);
        //    //using (stationeryEntities1 db = new stationeryEntities1())
        //    //{
        //    //    List<RequisitionFormDetail> temp = db.RequisitionFormDetails.ToList();

        //    //    string form_details_num = db.RequisitionFormDetails.Max(p => p.FormDetailsNumber);

        //    //    form_details_num = (form_details_num == null) ?  "1" : (Convert.ToInt32(form_details_num)+1).ToString() ;

        //    //    RequisitionFormDetail old_rec_to_update = (from f in db.RequisitionFormDetails
        //    //                                               where f.ItemNumber == form_detail_obj.ItemNumber && f.FormNumber == form_detail_obj.FormNumber
        //    //                                               select f).FirstOrDefault();
        //    //    if (old_rec_to_update != null)
        //    //    {
        //    //        old_rec_to_update.Quantity += form_detail_obj.Quantity;
        //    //    }
        //    //    else
        //    //    {
        //    //        db.RequisitionFormDetails.Add(new RequisitionFormDetail { FormDetailsNumber = form_details_num, FormNumber = form_detail_obj.FormNumber, ItemNumber = form_detail_obj.ItemNumber, Quantity = Convert.ToInt32(form_detail_obj.Quantity) });
        //    //    }

        //    //    db.SaveChanges();
        //    //}

        //    return RedirectToAction("addcart");
        //}

        //public ActionResult addcart()
        //{
        //    employee_utility eu = new employee_utility();
        //    Employee user = (Employee)Session["user"];
        //    Employee emp = eu.get_employee(user);
        //    DepartmentList dept = eu.get_department(user);
        //    List<StationeryCatalog> items = eu.get_catalog_items();
        //    string form_number = eu.get_form_no_();
        //    List<RequisitionFormDetail> form_cart_list = eu.get_RequisitionFormDetails(form_number);
        //    //Employee user = (Employee)Session["user"];
        //    //List<RequisitionFormDetail> form_cart_list;
        //    //Employee emp;
        //    //DepartmentList dept;
        //    //List<StationeryCatalog> items;
        //    //string form_number;

        //    //using (stationeryEntities1 db = new stationeryEntities1())
        //    //{
        //    //    emp = db.Employees.Find(user.Id);
        //    //    dept = db.DepartmentLists.Find(user.DepartmentCode);
        //    //    items = db.StationeryCatalogs.ToList();

        //    //    form_number = db.RequisitionForms.Max(p => p.FormNumber);
        //    //    form_cart_list = db.RequisitionFormDetails.Where(x => x.FormNumber == form_number).ToList();
        //    //}

        //    ViewData["catalog_list"] = items;
        //    ViewData["emp"] = emp;
        //    ViewData["emp_dept"] = dept;
        //    ViewData["form_cart"] = form_cart_list;
        //    ViewData["form_number"] = form_number;
        //    return View("newrequest");
        //}

        //public ActionResult submitrequest()
        //{
        //    var emp_id = Request.Form["emp_id"];
        //    var form_number = Request.Form["form_number"];

        //    employee_utility eu = new employee_utility();
        //    eu.submit_request(emp_id, form_number);
        //    //using (stationeryEntities1 db = new stationeryEntities1())
        //    //{
        //    //    RequisitionForm old_rec_to_update = (from f in db.RequisitionForms
        //    //                                               where f.EmployeeId == emp_id && f.FormNumber == form_number && f.Status== "temp_pending"
        //    //                                         select f).FirstOrDefault();
        //    //    if (old_rec_to_update != null)
        //    //    {
        //    //        old_rec_to_update.Status = "pending";
        //    //    }
        //    //    db.SaveChanges();
        //    //}
        //    return RedirectToAction("Index");
        //}

        //public ActionResult view_single_request(string form_id)
        //{
        //    employee_utility eu = new employee_utility();
        //    Employee user = (Employee)Session["user"];
        //    Employee emp = eu.get_employee(user);
        //    DepartmentList dept = eu.get_department(user);
        //    List<StationeryCatalog> items = eu.get_catalog_items();
        //    List<RequisitionFormDetail> form_cart_list = eu.get_RequisitionFormDetails(form_id);
        //    RequisitionForm form = eu.get_single_form_details(form_id);
        //    //Employee emp;
        //    //DepartmentList dept;
        //    //List<StationeryCatalog> items;
        //    //List<RequisitionFormDetail> form_cart_list;
        //    //RequisitionForm form;

        //    //using (stationeryEntities1 db = new stationeryEntities1())
        //    //{
        //    //    emp = db.Employees.Find(user.Id);
        //    //    dept = db.DepartmentLists.Find(user.DepartmentCode);
        //    //    items = db.StationeryCatalogs.ToList();
        //    //    form_cart_list = db.RequisitionFormDetails.Where(x => x.FormNumber == form_id).ToList();
        //    //    form = db.RequisitionForms.Find(form_id);
        //    //}
        //    ViewData["form_cart"] = form_cart_list;
        //    ViewData["form_number"] = form_id;
        //    ViewData["emp"] = emp;
        //    ViewData["emp_dept"] = dept;
        //    ViewData["catalog_list"] = items;
        //    ViewData["single_form_view"] = true;
        //    ViewData["req_form"] = form;

        //    return View("newrequest");
        //}

        //public ActionResult sendmail()
        //{
        //    util.SendEmail("dhilipkumar7235@gmail.com", "", "http://localhost:49971/employee/viewemail");
        //    return View();
        //}

        //public ActionResult viewemail()
        //{
        //    return View();
        //}
    }
}