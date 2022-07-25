
using System;

namespace ProgramacionIntermedia
{
    public abstract class Pair
    {
        public string Key { get; set; }
        public dynamic Value { get; set; }

    }

    public class Map<T> where T : Pair
    {
        private T[] _MyArray { get; set; }
        public Map()
        {
            _MyArray = new T[100];

        }
        
        public void Put(int i, T obj)
        {
            _MyArray[i] = obj;
        }

        public T GetAt(int i)
        {
            return _MyArray[i];
        }

        public T Get(string value)
        {
            foreach (var item in _MyArray)
            {
                if(item != null)
                {
                    if (item.Key.Equals(value))
                    {
                        return item;
                    }
                }
                
            }

            /*Este comentario lo dejo para entender de mejor manera el como funcionan 
              las cosas dentro del for*/
            //for (int i = 0; i < _MyArray.Length; i++)
            //{
            //    if (_MyArray[i] != null)
            //    {
            //        if (_MyArray[i].Key.Equals(value))
            //        {
            //            return _MyArray[i];
            //        }
            //    }
            //}
            throw new Exception("No se encontro el valor del objeto pair...");
        }


    }

    public static class MapExtesion
    {
        public static T GetFirstValueExtension<T>(this Map<T> obj) where T : Pair
        {
            return obj.GetAt(0);
        }
    }


    



}
