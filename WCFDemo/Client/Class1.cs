using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorServiceClient : System.ServiceModel.ClientBase<Client.CalculatorServices.CalculatorService>, Client.CalculatorServices.CalculatorService
    {

        public CalculatorServiceClient()
        {
        }

        public CalculatorServiceClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public CalculatorServiceClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public CalculatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public CalculatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public double Add(double x, double y)
        {
            return base.Channel.Add(x, y);
        }

        public double Subtract(double x, double y)
        {
            return base.Channel.Subtract(x, y);
        }

        public double Multiply(double x, double y)
        {
            return base.Channel.Multiply(x, y);
        }

        public double Divide(double x, double y)
        {
            return base.Channel.Divide(x, y);
        }
    }
}
