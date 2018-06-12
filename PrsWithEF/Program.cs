using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrsEF;

namespace PrsWithEF {
	class Program {

		private static PrsDbContext db = new PrsDbContext();

		void CalcPrTotal() {
			var prId = db.PurchaseRequests.SingleOrDefault(p => p.Id == 17 /*p.Description == "buy all the things"*/).Id;
			var total = db.PRLineItems
				.Where(pl => pl.PurchaseRequestId == prId)
				.Sum(li => li.Product.Price * li.Quantity);
			var pr = db.PurchaseRequests.SingleOrDefault(fred => fred.Id == prId);
			pr.Total = total;
			db.SaveChanges();
		}

		static void Main(string[] args) {
			//(new Program()).Run();
			(new Program()).CalcPrTotal();
		}

			

		
		void Run() {
			//var users = db.Users.ToList();
			//var user = db.Users.Find(1);
			//var nouser = db.Users.Find(111);

			//var addUser = new User {
			//	Username = "marpkimark",
			//	Password = "password",
			//	Firstname = "Marcus",
			//	Lastname = "fields",
			//	Phone = "513-444-4444",
			//	Email = "fieldsmu@yahoo.com",
			//	IsReviewer = true,
			//	IsAdmin = true,
			//	Active = true

			//};

			//var addedUser = db.Users.Add(addUser);
			//db.SaveChanges();

			////db.Users.Remove(addedUser);
			//db.SaveChanges();

			//var foundUser = db.Users.SingleOrDefault(u => u.Username == "fieldsmu");
			//if (foundUser != null) {
			//	foundUser.IsAdmin = false;
			//	db.SaveChanges();
			//}

			//db = new PrsDbContext();
			//var vendors = db.Vendors.ToList();
			//var vendor = db.Vendors.Find(1);
			//var addVendor = new Vendor() {
			//	Code = "AMAZ",
			//	Name = "Amazon",
			//	City = "Seattle",
			//	State = "WA",
			//	Address = "4444 Some Ln",
			//	Email = "amazon@amazon.com",
			//	Zip = "45069",
			//	Phone = "513-444-4444",
			//	IsPreapproved = true,
			//	Active = true
			//};

			//var addedVendor = db.Vendors.Add(addVendor);
			//db.SaveChanges();

			//var products = db.Products.ToList();
			//var product = products[0];
			//var vendorName = product.Vendor.Name;
			//var product = db.Products.Find(1);


			//var addPurchaseRequest = new PurchaseRequest() {
			//	Description = "buy all the things",
			//	Justification = "because theyre cool",
			//	DeliveryMode = "USPS",
			//	Status = "ON ROUTE",
			//	RejectionReason = "NONE",
			//	Total = 21009.84,
			//	UserId = db.Users.SingleOrDefault(u => u.Username == "fieldsmu").Id
			//};
			//var addedPurchaseRequest = db.PurchaseRequests.Add(addPurchaseRequest);
			//db.PurchaseRequests.Remove(addedPurchaseRequest);
			//db.SaveChanges();

			//var addPRLineItem = new PRLineItem() {
			//	Quantity = 3,
			//	ProductId = 29,
			//	PurchaseRequestId = 17
			//};
			//var addPRLineItem2 = new PRLineItem() {
			//	Quantity = 5,
			//	ProductId = 30,
			//	PurchaseRequestId = 17
			//};
			//var addPRLineItem3 = new PRLineItem() {
			//	Quantity = 7,
			//	ProductId = 31,
			//	PurchaseRequestId = 17
			//};
			//var addedPRLineItem = db.PRLineItem.Add(addPRLineItem);
			//var addedPRLineItem2 = db.PRLineItem.Add(addPRLineItem2);
			//var addedPRLineItem3 = db.PRLineItem.Add(addPRLineItem3);
			//db.PRLineItem.Remove(addedPRLineItem);
			//db.SaveChanges();
			//var lineitem = db.PRLineItem.Find(3);

			//var addProduct = new Product() {
			//	Name = "Yamaha",
			//	Price = 3999.99,
			//	Unit = "Each",
			//	Active = true,
			//	PartNumber = "4010",
			//	VendorId = 1,
			//	Vendor = null
			//};
			//var addProduct2 = new Product() {
			//	Name = "Scooter",
			//	Price = 399.99,
			//	Unit = "Each",
			//	Active = true,
			//	PartNumber = "40104",
			//	VendorId = 1,
			//	Vendor = null
			//};
			//var addProduct3 = new Product() {
			//	Name = "Iphone",
			//	Price = 999.99,
			//	Active = true,
			//	Unit = "Each",
			//	PartNumber = "1084",
			//	VendorId = 1,
			//	Vendor = null
			//};
			var addProduct4 = new Product() {
				Name = "Soap",
				Price = 9.99,
				Unit = "Each",
				Active = true,
				PartNumber = "1084",
				VendorId = 1,
				Vendor = null
			};
			//var addedProduct = db.Products.Add(addProduct);
			//var addedProduct2 = db.Products.Add(addProduct2);
			//var addedProduct3 = db.Products.Add(addProduct3);
			var addedProduct4 = db.Products.Add(addProduct4);
			db.SaveChanges();
		}
	}
}
