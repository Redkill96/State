
using System;
using System.Linq;
using System.Collections.Generic;


namespace Bewegungserkennung
{
    class Program
    {
        static void Main(string[] args)
        {
            dataReader d = new dataReader("KinectDaten_Pascal.csv");
            List<Shape> shapes = d.readData();
            KMclustering k = new KMclustering(shapes[5], new point(1.0e+17,1.0e+17),2,0.1);
            k.clustering();
            FSM machine = new FSM(k, shapes[5],3);
            return;
        }
    }
}

