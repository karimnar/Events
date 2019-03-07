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
            var Universities = new List<University>
            {
                new University{UnivName="Universit� de Tunis"},
                new University{UnivName="Universit� de Tunis El-Manar "},
                new University{UnivName="Universit� de Carthage"},
                new University{UnivName="Universit� de Jendouba"},
                new University{UnivName="Universit� de Gab�s"},
                new University{UnivName="Universit� de Sousse"},
                new University{UnivName="Universit� de Monastir"},
                new University{UnivName="Universit� de Sfax "},
                new University{UnivName="Universit� Zitouna"},
                new University{UnivName="Universit� de la Manouba"},
                new University{UnivName="Universit� de Kairouan "},
                new University{UnivName="Universit� de Gafsa"},
                new University{UnivName="Direction des ISET"},
                new University{UnivName="Universit� Virtuelle de Tunis"},
            };
            Universities.ForEach(e => context.University.AddOrUpdate(p => p.UnivName, e));
            context.SaveChanges();
        }
    }
}
