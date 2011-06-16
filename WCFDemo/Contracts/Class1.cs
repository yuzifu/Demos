using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Contracts
{
    [ServiceContract(Name="CalculatorService", Namespace="http://www.yuzifu.net/")]   
    public interface ICalculator   
    {   
        [OperationContract]   
        double Add(double x, double y);   
        
        [OperationContract]  
        double Subtract(double x, double y); 
        
        [OperationContract]  
        double Multiply(double x, double y);  
        
        [OperationContract]  
        double Divide(double x, double y);         
    } 
}
