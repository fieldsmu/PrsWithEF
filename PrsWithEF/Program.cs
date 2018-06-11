using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrsEF;

namespace PrsWithEF {
	class Program {

		private static readonly PrsDbContext db = new PrsDbContext();

		static void Main(string[] args) {

			var users = db.Users.ToList();
			var user = db.Users.Find(1);
			var nouser = db.Users.Find(111);

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

			//db.Users.Remove(addedUser);
			//db.SaveChanges();

			var foundUser = db.Users.SingleOrDefault(u => u.Username == "fieldsmu");
			if (foundUser != null) {
				foundUser.IsAdmin = false;
				db.SaveChanges();
			}

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

			var products = db.Products.ToList();
			var product = products[0];
			var vendorName = product.Vendor.Name;
			//var product = db.Products.Find(1);
			var addProduct = new Product() {
				Name = "Fire",
				Price = 39.99,
				Unit = "Each",
				Active = true,
				PartNumber = "401084",
				VendorId = 1,
				Vendor = null
			};
			var addedProduct = db.Products.Add(addProduct);
			db.SaveChanges();
		}
	}
}
