using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NbaLeagueRomania.repository
{
    class DataReader
    {

        public static List<T> ReadData<T>(string filename, CreateEntity<T> createEntity)
        {
            List<T> list = new List<T>();
            using (StreamReader sr = new StreamReader(filename))
            {
                string s;
                while((s =sr.ReadLine())!=null)
                {
                    T entity = createEntity(s);
                    list.Add(entity);
                }
            }
            return list;
        }
    }
}
