using NbaLeagueRomania.entities;
using NbaLeagueRomania.entities.validators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NbaLeagueRomania.repository
{
    class ActivePlayerInFileRepository:InFileRepository<Tuple<long,long>,ActivePlayer>
    {
        public ActivePlayerInFileRepository(IValidator<ActivePlayer> validator, string filename) : base(validator, filename, EntityToFileMapping.CreateActivePlayer)
        {

        }

        public override ActivePlayer Save(ActivePlayer entity)
        {
            writeToFile(entity);
            return base.Save(entity);
        }

        protected override void writeToFile(ActivePlayer entity)
        {
            string toWrite = entity.idJucator + "|" + entity.idMeci + "|" + entity.nrPuncteInscrise + "|" + entity.tip;
            using (StreamWriter w = File.AppendText(this.filename))
            {
                w.WriteLine(toWrite);
            }
        }
    }
}
