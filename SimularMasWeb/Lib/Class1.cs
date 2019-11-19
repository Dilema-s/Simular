using System;
using System.Collections.Generic;
using System.Drawing;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using QLNet;

namespace SimularMasWeb.Lib
{
    public class Class1
    {
        public int Add(int X, int Y)
        {
            //GeneralizedBlackScholesProcess gbsp = new GeneralizedBlackScholesProcess();
            int? timeSteps = 10;
            int? timeStepsPerYear = null;
            bool antitheticVariate = false;
            bool controlVariate = false;
            int? requiredSamples = 10000;
            double? maxSamples = null;
            ulong seed = UInt64.MaxValue;


            //MCAmericanEngine <PseudoRandom, Statistics> monteCarlo =
                //new MCAmericanEngine<PseudoRandom, Statistics>(gbsp, timeSteps, timeStepsPerYear, antitheticVariate, controlVariate, requiredSamples, maxSamples, seed);

            return X + Y;
        }
        


        //public NormalDistribution myFunction()
        //{
        //    return new NormalDistribution(2.3, 12.32);
        //} 
        

    }
}