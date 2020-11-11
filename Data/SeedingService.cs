using System;

using System.Linq;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department(1, "Musics");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Foods");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Janis Joplin", "Janis@gmail.com", new DateTime(1943, 1, 19), 1000.0, d1);
            Seller s2 = new Seller(2, "James Hetfield", "James@gmail.com", new DateTime(1963, 8, 3), 3500.0, d2);
            Seller s3 = new Seller(3, "Jimi Hendrix", "JimiH@gmail.com", new DateTime(1942, 11, 27), 2200.0, d1);
      

            SalesRecord r1 = new SalesRecord(1, new DateTime(2020, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2020, 09, 4), 7000.0, SaleStatus.Billed, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2020, 09, 13), 4000.0, SaleStatus.Canceled, s2);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2020, 09, 1), 8000.0, SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2020, 09, 21), 3000.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2020, 09, 15), 2000.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2020, 09, 28), 13000.0, SaleStatus.Billed, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2020, 09, 11), 4000.0, SaleStatus.Billed, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2020, 09, 14), 11000.0, SaleStatus.Pending, s2);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2020, 09, 7), 9000.0, SaleStatus.Billed, s3);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2020, 09, 13), 6000.0, SaleStatus.Billed, s1);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2020, 09, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2020, 09, 29), 10000.0, SaleStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2018, 09, 4), 3000.0, SaleStatus.Billed, s2);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2018, 09, 12), 4000.0, SaleStatus.Billed, s1);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2018, 10, 5), 2000.0, SaleStatus.Billed, s2);


            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16
            );

            _context.SaveChanges();
        }
    }
}