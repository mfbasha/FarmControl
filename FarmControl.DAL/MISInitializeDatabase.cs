using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.DAL.DataInitialize
{
    public class MISInitializeDatabase
    {
        public static void InitializeDB(DbContext dbc)
        {
            dbc.Database.EnsureCreated();
            //#region Coverage Service Type
            ////if (!dbc.Coverage_Category.Any())
            ////{
            ////    dbc.Coverage_Category.AddRange(new CoverageServiceType[] { new CoverageServiceType {CoveredService_ID=1 ,CovarageName="Death",Multiples=1 } ,
            ////        new CoverageServiceType { CoveredService_ID=2 , CovarageName = "Permeant total disability", Multiples = 1 },
            ////        new CoverageServiceType { CoveredService_ID=3 ,CovarageName = "Accidental death", Multiples = 2 },
            ////        new CoverageServiceType { CoveredService_ID=4 ,CovarageName = "Accidental total disability", Multiples = 1 },
            ////        new CoverageServiceType { CoveredService_ID=5 ,CovarageName = "Permeant partial disability", Multiples = 1 },
            ////        new CoverageServiceType { CoveredService_ID=6 ,CovarageName = "Accidental partial disability", Multiples = 1 },
            ////        new CoverageServiceType { CoveredService_ID=7 ,CovarageName = "Personal Accident", Multiples = 1 }
            ////    });
            ////}
            //if (!dbc.Coverage_Category.Any())
            //{
            //    dbc.Coverage_Category.AddRange(new CoverageServiceType[] { new CoverageServiceType {CovarageName="Death",Multiples=1 } ,
            //        new CoverageServiceType {  CovarageName = "Permeant total disability", Multiples = 1 },
            //        new CoverageServiceType {  CovarageName = "Accidental death", Multiples = 2 },
            //        new CoverageServiceType {  CovarageName = "Accidental total disability", Multiples = 1 },
            //        new CoverageServiceType {  CovarageName = "Permeant partial disability", Multiples = 1 },
            //        new CoverageServiceType {  CovarageName = "Accidental partial disability", Multiples = 1 },
            //        new CoverageServiceType {  CovarageName = "Personal Accident", Multiples = 1 }
            //    });
            //}
            //#endregion
            //#region Medical benefits
            ////if (!dbc.Medical_benefits.Any())
            ////{
            ////    dbc.Medical_benefits.AddRange(new MedicalBenifit[] { new MedicalBenifit {MedicalBenifit_id=1, BenifitName="Dental" },
            ////        new MedicalBenifit {MedicalBenifit_id=2, BenifitName="Optics" },
            ////        new MedicalBenifit {MedicalBenifit_id=3, BenifitName="Hospital" },
            ////        new MedicalBenifit {MedicalBenifit_id=4, BenifitName="Clinic" },
            ////        new MedicalBenifit {MedicalBenifit_id=5, BenifitName="Medical Scan" },
            ////        new MedicalBenifit {MedicalBenifit_id=6, BenifitName="Medications" },
            ////        new MedicalBenifit {MedicalBenifit_id=7, BenifitName="Lab analysis" },
            ////        new MedicalBenifit {MedicalBenifit_id=8, BenifitName="Physical therapy" }
            ////    });
            ////}
            //if (!dbc.Medical_benefits.Any())
            //{
            //    dbc.Medical_benefits.AddRange(new MedicalBenifit[] { new MedicalBenifit {BenifitName="Dental" },
            //        new MedicalBenifit {BenifitName="Optics" },
            //        new MedicalBenifit {BenifitName="Hospital" },
            //        new MedicalBenifit {BenifitName="Clinic" },
            //        new MedicalBenifit {BenifitName="Medical Scan" },
            //        new MedicalBenifit {BenifitName="Medications" },
            //        new MedicalBenifit {BenifitName="Lab analysis" },
            //        new MedicalBenifit {BenifitName="Physical therapy" }
            //    });
            //}
            //#endregion
            //#region User Roles
            //if (!dbc.Roles.Any())
            //{
            //    dbc.Roles.AddRange(new MISRole[] { new MISRole { Id =Guid.NewGuid().ToString(), NormalizedName = "Managers", Name="Managers" },
            //        new MISRole { Id =Guid.NewGuid().ToString(), NormalizedName = "System Admins",Name = "System Admins" },
            //        new MISRole {Id =Guid.NewGuid().ToString(), NormalizedName = "Users",Name="Users" }
            //    });
            //}
            //#endregion
            dbc.SaveChanges();
        }
    }
}
