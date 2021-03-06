﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NibsMVC.EDMX;
using NibsMVC.Models;
using NibsMVC.Repository;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;
using System.Drawing;

namespace NibsMVC.Controllers
{
    [Authorize(Roles = "admin,outlet,operator")]
    public class KitchenController : Controller
    {
        //
        // GET: /Kitchen/
        KitchenItemRepository obj = new KitchenItemRepository();
        NIBSEntities db = new NIBSEntities();


        #region
        public ActionResult ViewRawCategory()
        {
            return View(obj.ShowAllRawCategoriesList());
        }
        public ActionResult AddRawCategory(int Id = 0)
        {
            return View(obj.EditRawCategory(Id));
        }
        [HttpPost]
        public ActionResult AddRawCategory(AddRawCategoryModel model)
        {
            var Data = obj.SaveRawCategory(model);
            TempData["Error"] = Data;
            return RedirectToAction("AddRawCategory");
        }
        public ActionResult DeleteCategory(int Id = 0)
        {
            var data = obj.DeleteRawCategory(Id);
            TempData["Error"] = data;
            return RedirectToAction("ViewRawCategory");
        }
        public ActionResult DeleteIndent(int Id = 0)
        {
            var data = obj.DeleteRawIndent(Id);
            TempData["Error"] = data;
            return RedirectToAction("KitchenRawList");
        }
        public ActionResult DeleteSubIndent(int Id = 0)
        {
            var Path = Server.MapPath("/xmlkot/SubItemRawMaterial.xml");
            var data = obj.DeleteSubRawIndent(Id, Path);
            TempData["Error"] = data;
            return RedirectToAction("SubItemRawList");
        }
        #endregion

        #region
        public ActionResult Index()
        {


            return View(obj.ShowAllRawMaterialsList());
        }
        public ActionResult Create(int Id = 0)
        {
            IEnumerable<SelectListItem> Categorylist = (from q in db.RawCategories where q.Active == true select q).AsEnumerable().Select(q => new SelectListItem() { Text = q.Name, Value = q.RawCategoryID.ToString() });

            ViewBag.Categorylists = new SelectList(Categorylist, "Value", "Text");

            IEnumerable<SelectListItem> UnitList = (from z in db.Units where z.Active == true select z).AsEnumerable().Select(z => new SelectListItem() { Text = z.UnitName, Value = z.UnitName.ToString() });

            ViewBag.UnitList = new SelectList(UnitList, "Value", "Text");

            return View(obj.EditRawMaterial(Id));
        }
        [HttpPost]
        public ActionResult Create(RawMaterialsModel model)
        {
            var Data = obj.SaveRawMaterial(model);
            TempData["Error"] = Data;
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int Id = 0)
        {
            var data = obj.DeleteRawMaterial(Id);
            TempData["Error"] = data;
            return RedirectToAction("Index");
        }
        public ActionResult DeleteIndentItem(int id=0)
        {
            var data = obj.DeleteRawIngridentsItem(id);
            TempData["Error"] = data;
            return RedirectToAction("ListRawItem");
        }
        public ActionResult genBarcode()
        {
            try
            {
                List<RawMaterialsModel> List = new List<RawMaterialsModel>();
                var data = (from q in db.tbl_RawMaterials where (q.barcode.Trim() == "" || q.barcode == null) select q).ToList();
                foreach (var item in data)
                {

                    string barcode = item.RawCategory.Name.Substring(0, 1) + item.Name.Substring(0, 1) + item.rawcategoryId + item.RawMaterialId;

                    MemoryStream ms = new MemoryStream(obj.GenerateBarcode(barcode));
                    Image returnImage = Image.FromStream(ms);

                    returnImage.Save(Server.MapPath("~/Barcodes/") + barcode + ".png");


                    string webconnection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                    SqlConnection con = new SqlConnection(webconnection);
                    SqlCommand cmd = new SqlCommand("Update tbl_RawMaterials set barcode = '" + barcode + "'  where RawMaterialId = " + item.RawMaterialId, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //System.Web.HttpContext.Current.Response.ContentType = "image/png";
                    //System.Web.HttpContext.Current.Response.BinaryWrite(obj.GenerateBarcode(tb.barcode));


                }
                TempData["Error"] = "Baecode Update Successfully";

            }
            catch
            {
                TempData["Error"] = "Something went wrong";
            }


            return RedirectToAction("Index");
        }


        #endregion

        // for kitchen Raw Materials
        #region
        public ActionResult AddIndent()
        {

            return View(obj.AddKitchenRawIndent());
        }

        public ActionResult ListRawItem(int id = 0)
        {

            return View(obj.ListKitchenRawIndent(id));
        }
        //public ActionResult EditRawIndent(int id=0)
        //{
        //    return View(obj.EditAssignList(id));
        //}
        public ActionResult AddSubMenuIndent()
        {

            return View(obj.AddSubMenuRawIndent());
        }

        public string ListOfItems(string Id)
        {
            int ItemId = Convert.ToInt32(Id);
            string result = obj.GetListofItems(ItemId);
            return result;

        }
        public string getUnit(string Id)
        {
            int ItemId = Convert.ToInt32(Id);
            string result = obj.getUnit(ItemId);
            return result;

        }
        public string ListOfRawItems(string Id)
        {
            int ItemId = Convert.ToInt32(Id);
            string result = obj.GetListofRawItems(ItemId);
            return result;

        }
        public string ListOfsubRawIndent(string Id)
        {
            int SubItemId = Convert.ToInt32(Id);
            var Path = Server.MapPath("/xmlkot/SubItemRawMaterial.xml");
            var Data = obj.UpdateSubItemRawMaterial(SubItemId, Path);
            return Data;

        }
        public string UpdateKitchenRawMaterial(KitchenRawIndentModel model)
        {
            var Path = Server.MapPath("/xmlkot/KitchenRawMaterial.xml");
            var Data = obj.UpdateKitchenRawMaterail(model, Path);
            return Data;
        }
        public string UpdateSubItemRawMaterial(SubItemRawIndentModel model)
        {
            var Path = Server.MapPath("/xmlkot/SubItemRawMaterial.xml");
            var Data = obj.UpdateSubItemRawMaterial(model, Path);
            return Data;
        } 
        public ActionResult SaveKitchenRawMaterail() 
        {
            var Path = Server.MapPath("/xmlkot/KitchenRawMaterial.xml");
            var Data = obj.SaveRawMaterial(Path);
            return RedirectToAction("KitchenRawList");
        }

        public ActionResult SaveSubItemRawMaterail()
        {
            var Path = Server.MapPath("/xmlkot/SubItemRawMaterial.xml");
            var Data = obj.SaveSubItemRawMaterial(Path);
            return RedirectToAction("SubItemRawList");
        }

        public ActionResult KitchenRawList()
        {
            return View(obj.ListOfMaterial());
        }
        public ActionResult AssignedList()
        {
            return View(obj.ListOfAssignedSubItemMaterial());
        }

        public ActionResult DeleteAssignedSubItem(int Id)
        {
            var Data = obj.DeleteAssignedSubItem(Id);
             TempData["Error"] = Data;
            return RedirectToAction("AssignedList");
        }


        public string deleteRaw(string Id)
        {
            var Path = Server.MapPath("/xmlkot/KitchenRawMaterial.xml");
            var Data = obj.DeleteRaw(Id, Path);
            return Data;
        }

        public ActionResult SubItemRawList()
        {
            return View(obj.ListOfSubItemMaterial());
        }


        public string deleteSubRaw(string Id)
        {
            var Path = Server.MapPath("/xmlkot/SubItemRawMaterial.xml");
            var Data = obj.DeleteSubRaw(Id, Path);
            return Data;
        }
        #endregion

        //---------------Delete kitchen Raw list------------//
        //public ActionResult DeleteIndent(int id)
        //{
        //    try {
        //        var data = (from p in db.tbl_KitchenRawIndent where p.ItemId == id select p).ToList();
        //        foreach (var item in data)
        //        {
        //            db.tbl_KitchenRawIndent.Remove(item);
        //            db.SaveChanges();
        //        }
        //        TempData["kitchenerror"] = "Delete Successfully";
        //            return RedirectToAction("KitchenRawList");
        //    }
        //        catch(Exception ex)
        //    {
        //        TempData["kitchenerror"] = ex.Message;
        //            return RedirectToAction("KitchenRawList");
        //        }

        //}

        [HttpPost]
        public string Assign(int SubItemid=0)
        {
            AddItemRepository dis = new AddItemRepository();
            List<SubItemAssignRawModel> assignsubitem = dis.subItemwise(SubItemid );
            StringBuilder sb = new StringBuilder();
            sb.Append("<table class='table table-bordered' id='tblsubRawitems'>");
            sb.Append("<thead>");
            sb.Append("<tr><th>  <input type=\"checkbox\" id=\"chkAll\" /> Select </th><th>Qty</th><th>Unit</th>");
            sb.Append("</thead>");
            sb.Append("<tbody>");
            string portion = "";
            foreach (var item in assignsubitem)
            {

                if (item != null)
                {
                    if (item.Assigned == true)
                    {
                        sb.Append("<tr><td><input type='checkbox' id='" + item.RawMaterialId  + "' name='RawMaterialId' checked value='" + item.RawMaterialId  + "' class='checkbox'>" + item.RawMaterialName  + "</td>");
                        sb.Append("<td><input type='textbox' class='form-control'name='Qty' style='margin:2px 6px'value='" + item.Qty  + "' id='" + item.RawMaterialId  + "' ></td>");
                        sb.Append("<td> " + item.Unit +"</td>");

                    }
                    else
                    {
                        sb.Append("<tr><td><input type='checkbox' id='" + item.RawMaterialId + "' name='RawMaterialId' value='" + item.RawMaterialId + "' class='checkbox'>" + item.RawMaterialName + "</td>");
                        sb.Append("<td><input type='textbox' class='form-control'name='Qty' style='margin:2px 6px'value='" + item.Qty + "' id='" + item.RawMaterialId + "' ></td>");
                        sb.Append("<td> " + item.Unit + "</td>");
                    }

                    //
                }
                portion = item.Portion.ToString();

            }
            sb.Append("</tbody>");
            sb.Append("<table>");
            sb.Append("~" + portion);
            return sb.ToString();
        }

        public ActionResult AssignRawSubItem()
        {

            AssignView();

            return View();
        }
        private void AssignView()
        {


            IEnumerable<SelectListItem> SubItemList = (from q in db.tblSubItems where q.Active == true select q).AsEnumerable().Select(q => new SelectListItem() { Text = q.Name, Value = q.SubItemId.ToString() });

            ViewBag.SubItemList = new SelectList(SubItemList, "Value", "Text");
        }

        [HttpPost]
        public ActionResult AssignRawSubItem(AssignRawSubItemModel model)
        {
            try
            {
                //var delete = (from p in db.tblMenuOutlets where p.CategoryId == model.CategoryId && p.OutletId == model.OutletId select p).ToList();
                //foreach (var item in delete)
                //{
                //    db.tblMenuOutlets.Remove(item);
                //    db.SaveChanges();
                //}

                tblAssignRawSubItemMst tbMst = new tblAssignRawSubItemMst();
                tbMst.AssignDate = Convert.ToDateTime(model.DateTime); //DateTime.Today;
                tbMst.Portion = (int)model.Portion;
                tbMst.SubItemId = model.SubItemId;
                db.tblAssignRawSubItemMsts.Add(tbMst);
                db.SaveChanges();


                tblAsgnRawSubItemDet tb = new tblAsgnRawSubItemDet();
                for (int i = 0; i < model.RawMaterialId.Length; i++)
                {
                    

                    tb.RawMaterialId  = model.RawMaterialId[i];
                    tb.Qty = model.qty[i];
                    tb.AsgnRawSubItemMstId = db.tblAssignRawSubItemMsts.Max(p=>p.Id);
                    db.tblAsgnRawSubItemDets.Add(tb);
                    db.SaveChanges();
                }
                TempData["menuerror"] = "Assigned Succesfully...";
                return RedirectToAction("AssignRawSubItem");
            }
            catch
            {
                TempData["menuerror"] = "Try Agian !";
                return RedirectToAction("AssignRawSubItem");
            }

        }
    }
}
