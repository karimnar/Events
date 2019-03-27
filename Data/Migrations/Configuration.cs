namespace Data.Migrations
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.DatabContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.DatabContext context)
        {
        //    var University = new List<University>
        //    {
        //        new University{UnivName="Universit� de Tunis"},
        //        new University{UnivName="Universit� de Tunis El-Manar "},
        //        new University{UnivName="Universit� de Carthage"},
        //        new University{UnivName="Universit� de Jendouba"},
        //        new University{UnivName="Universit� de Gab�s"},
        //        new University{UnivName="Universit� de Sousse"},
        //        new University{UnivName="Universit� de Monastir"},
        //        new University{UnivName="Universit� de Sfax "},
        //        new University{UnivName="Universit� Zitouna"},
        //        new University{UnivName="Universit� de la Manouba"},
        //        new University{UnivName="Universit� de Kairouan "},
        //        new University{UnivName="Universit� de Gafsa"},
        //        new University{UnivName="Direction des ISET"},
        //        new University{UnivName="Universit� Virtuelle de Tunis"},
        //    };
        //    University.ForEach(e => context.University.AddOrUpdate(p => p.UnivName, e));
        //    context.SaveChanges();

        //    var Admins = new List<Admin>
        //    {
        //        new Admin{nameAdmin="karim",mailAdmin="admin@admin.com",passwordAdmin="admin",isSuperAdmin=true},

        //    };
        //    Admins.ForEach(e => context.Admin.AddOrUpdate(c => c.mailAdmin, e));
        //    context.SaveChanges();


        //    var Organization = new List<organization>
        //    {

        //        new organization{orgname="Institut Sup�rieur de Gestion de Tunis",university=context.University.Find(1)},
        //        new organization{orgname="Institut Pr�paratoire aux Etudes d'Ing�nieurs de Tunis",university=context.University.Find(1)},
        //        new organization{orgname="Ecole Normale Sup�rieure",university=context.University.Find(1)},
        //        new organization{orgname="Facult� des Sciences Economique et de Gestion de Tunis",university=context.University.Find(2)},
        //        new organization{orgname="Facult� des sciences de tunis",university=context.University.Find(2)},
        //        new organization{orgname="Ecole Nationale d'Ing�nieurs de Tunis",university=context.University.Find(2)},
        //        new organization{orgname="Ecole Nationale des Sciences de l'Informatique",university=context.University.Find(10)},
        //    };
        //    Organization.ForEach(e => context.organization.AddOrUpdate(c => c.orgname, e));
        //    context.SaveChanges();

        }


       

    }
}

