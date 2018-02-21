using System;
using RestSharp;

namespace c__mpesa_libraries
{
   class Program
    {
        static void OAuth()
        {
            var client = new RestClient("https://sandbox.safaricom.co.ke/oauth/v1/generate?grant_type=client_credentials");
            var request = new RestRequest(Method.GET);
            String consumerKey = "Z5jUd4NDfzAXbMLGlrQ3tUtK60o0U4x3";
            String consumerSecret = "CUtVcRYq04xfxROj";
            var key = consumerKey + ":" + consumerSecret;
            var keyBytes = System.Text.Encoding.UTF8.GetBytes(key);
            var test = System.Convert.ToBase64String(keyBytes);
            request.AddHeader("Authorization", "Basic " + test);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);
        }

        static void B2C()
        {
            var client = new RestClient("https://sandbox.safaricom.co.ke/mpesa/b2c/v1/paymentrequest");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + "INSERT ACCESS TOKEN HERE");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\r\n    " +
                "\"InitiatorName\": \"testapi\",\r\n    " +
                "\"SecurityCredential\": \"H/2ZJBV/s3dnkw0wMgMqFUe1DFBCFPvolC2or8IGCKcQgGEZ7ut1EPZzooF+7PF/ozUX1Raf3l30h0q4Pj7czZFUzm4Wp8j3hz3TGl3r2SfGxx9v6RfhdElF/5/jenbrP5LxeRxMSfK5wUKu2sM9ge0rcZVMvmSmAmKMQkVHEAw0U/KS8ba9QnprQoLMQJyW9ukF5RNoQyCoyw1bUUCl6odPt6Niq2AstrtTQ8EnwPGkm+1iQNCKsZoSEjsHO6YS7Xa2xnSzG4ld4OxtEvajX5RRYY9cZVZyDnRkrS8AE6CJIop238RXQ4YhWJL0UP93wZ33+oBmWLnMCtb28HIgRQ==\",\r\n    " +
                "\"CommandID\": \"BusinessPayment\",\r\n    " +
                "\"Amount\": \"100\",\r\n    " +
                "\"PartyA\": \"600133\",\r\n    " +
                "\"PartyB\": \"254708374149\",\r\n    " +
                "\"Remarks\": \"test\",\r\n    " +
                "\"QueueTimeOutURL\": \"https://hookbin.com/bin/vgLL995o\",\r\n    " +
                "\"ResultURL\": \"https://hookbin.com/bin/vgLL995o\",\r\n\t" +
                "\"Occasion\": \"test\"\r\n}", 
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);
        }

        static void B2B()
        {
            var client = new RestClient("https://sandbox.safaricom.co.ke/mpesa/b2b/v1/paymentrequest");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + "INSERT ACCESS TOKEN HERE");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\r\n    " +
                "\"Initiator\": \"testapi\",\r\n    " +
                "\"SecurityCredential\": \"H/2ZJBV/s3dnkw0wMgMqFUe1DFBCFPvolC2or8IGCKcQgGEZ7ut1EPZzooF+7PF/ozUX1Raf3l30h0q4Pj7czZFUzm4Wp8j3hz3TGl3r2SfGxx9v6RfhdElF/5/jenbrP5LxeRxMSfK5wUKu2sM9ge0rcZVMvmSmAmKMQkVHEAw0U/KS8ba9QnprQoLMQJyW9ukF5RNoQyCoyw1bUUCl6odPt6Niq2AstrtTQ8EnwPGkm+1iQNCKsZoSEjsHO6YS7Xa2xnSzG4ld4OxtEvajX5RRYY9cZVZyDnRkrS8AE6CJIop238RXQ4YhWJL0UP93wZ33+oBmWLnMCtb28HIgRQ==\",\r\n    " +
                "\"CommandID\": \"BusinessPayBill\",\r\n    " +
                "\"SenderIdentifierType\": \"4\",\r\n    " +
                "\"RecieverIdentifierType\": \"4\",\r\n    " +
                "\"Amount\": \"100\",\r\n    " +
                "\"PartyA\": \"600133\",\r\n    " +
                "\"PartyB\": \"600000\",\r\n    " +
                "\"AccountReference\": \"test123\",\r\n    " +
                "\"Remarks\": \"test\",\r\n    " +
                "\"QueueTimeOutURL\": \"https://hookbin.com/bin/vgLL995o\",\r\n    " +
                "\"ResultURL\": \"https://hookbin.com/bin/vgLL995o\"\r\n}", 
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);
        }

        static void C2B_Register()
        {
            var client = new RestClient("https://sandbox.safaricom.co.ke/mpesa/c2b/v1/registerurl");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + "INSERT ACCESS TOKEN HERE");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\r\n    " +
                "\"ShortCode\": \"600133\",\r\n    " +
                "\"ResponseType\": \"Completed\",\r\n    " +
                "\"ConfirmationURL\": \"https://hookbin.com/bin/vgLL995o\",\r\n    " +
                "\"ValidationURL\": \"https://hookbin.com/bin/vgLL995o\"\r\n}", 
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);
        }

        static void C2B_Simulate()
        {
            var client = new RestClient("https://sandbox.safaricom.co.ke/mpesa/c2b/v1/simulate");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + "INSERT ACCESS TOKEN HERE");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\r\n    " +
                "\"ShortCode\":\"600133\",\r\n    " +
                "\"CommandID\":\"CustomerPayBillOnline\",\r\n    " +
                "\"Amount\":\"100\",\r\n    " +
                "\"Msisdn\":\"254708374149\",\r\n    " +
                "\"BillRefNumber\":\"0000\"\r\n}", 
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);
        }

        static void Lipa_Na_Mpesa_Online()
        {
            var client = new RestClient("https://sandbox.safaricom.co.ke/mpesa/stkpush/v1/processrequest");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + "INSERT ACCESS TOKEN HERE");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\r\n    " +
                "\"BusinessShortCode\": \"174379\",\r\n    " +
                "\"Password\": \"MTc0Mzc5YmZiMjc5ZjlhYTliZGJjZjE1OGU5N2RkNzFhNDY3Y2QyZTBjODkzMDU5YjEwZjc4ZTZiNzJhZGExZWQyYzkxOTIwMTgwMTA5MTE1NDU5\",\r\n    " +
                "\"Timestamp\": \"20180109115459\",\r\n    " +
                "\"TransactionType\": \"CustomerPayBillOnline\",\r\n    " +
                "\"Amount\": \"1\",\r\n    " +
                "\"PartyA\": \"254708604129\",\r\n    " +
                "\"PartyB\": \"174379\",\r\n    " +
                "\"PhoneNumber\": \"254708604229\",\r\n    " +
                "\"CallBackURL\": \"https://hookbin.com/bin/vgLL995o\",\r\n    " +
                "\"AccountReference\": \"tune\",\r\n    " +
                "\"TransactionDesc\": \"tune\"\r\n}", 
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);
        }

        static void Lipa_Na_Mpesa_Query()
        {
            var client = new RestClient("https://sandbox.safaricom.co.ke/mpesa/stkpushquery/v1/query");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + "INSERT ACCESS TOKEN HERE");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\r\n    " +
                "\"BusinessShortCode\": \" \" ,\r\n    " +
                "\"Password\": \" \",\r\n    " +
                "\"Timestamp\": \" \",\r\n    " +
                "\"CheckoutRequestID\": \" \"\r\n}", 
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);
        }

        static void Reversal()
        {
            var client = new RestClient("https://sandbox.safaricom.co.ke/mpesa/reversal/v1/request");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + "INSERT ACCESS TOKEN HERE");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\r\n    " +
                "\"Initiator\": \"testapi\",\r\n    " +
                "\"SecurityCredential\": \"LUna4kbprA2lOFxrZcFFf0wk1oDvAGVKmKu5+oMQ54U90AtIOebW1PwwK+0aS8vUWXhtGn1fMBmJir+YyhWarvJYChpapFA7Jn46JMsSvyJKZh0cgAAL/WkA0AMapdO/q8opVpbm14LE7vD+B8k+IGUIMkBQ9pd3OG3V30SJFvLw54rd2pjdyBV2//SRqLebu847fib/IYK/8Z0L2IMDrtQ7ssrxZYQ0BnOT61nfnUuAa/BZ6syEShSX021mlUTJs9oGUw2VTkvq3srzV+JQpRcmB8WAjKC8VynHscyhxKfAl0wS3ceAQvSwPETPzwB1uLeTzz1hp7LA1RbtOiQEjw==\",\r\n    " +
                "\"CommandID\": \"TransactionReversal\",\r\n    " +
                "\"TransactionID\": \"MAC41H3Y7M\",\r\n    " +
                "\"Amount\": \"100\",\r\n    " +
                "\"ReceiverParty\": \"600000\",\r\n    " +
                "\"RecieverIdentifierType\": \"4\",\r\n    " +
                "\"ResultURL\": \"https://hookb.in/KlwOYO68\",\r\n    " +
                "\"QueueTimeOutURL\": \"https://hookb.in/KlwOYO68\",\r\n    " +
                "\"Remarks\": \"test\",\r\n    " +
                "\"Occasion\": \"test\"\r\n}", 
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);
        }

        static void Transcation_Status()
        {
            var client = new RestClient("https://sandbox.safaricom.co.ke/mpesa/transactionstatus/v1/query");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + "INSERT ACCESS TOKEN HERE");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\r\n    " +
                "\"Initiator\": \"\",\r\n    " +
                "\"SecurityCredential\": \"\",\r\n    " +
                "\"CommandID\": \"TransactionStatusQuery\",\r\n    " +
                "\"TransactionID\": \"\",\r\n    " +
                "\"PartyA\": \"\",\r\n    " +
                "\"IdentifierType\": \"\",\r\n    " +
                "\"ResultURL\": \"\",\r\n    " +
                "\"QueueTimeOutURL\": \"\",\r\n    " +
                "\"Remarks\": \"\",\r\n    " +
                "\"Occasion\": \"\"\r\n}", 
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);
        }

        static void Account_Balance()
        {
            var client = new RestClient("https://sandbox.safaricom.co.ke/mpesa/accountbalance/v1/query");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + "INSERT ACCESS TOKEN HERE");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\r\n    " +
                "\"Initiator\": \"\",\r\n    " +
                "\"SecurityCredential\": \"\",\r\n    " +
                "\"CommandID\": \"AccountBalance\",\r\n    " +
                "\"PartyA\": \"\",\r\n    " +
                "\"IdentifierType\": \"4\",\r\n    " +
                "\"Remarks\": \"\",\r\n    " +
                "\"QueueTimeOutURL\": \"\",\r\n    " +
                "\"ResultURL\": \"\"\r\n}", 
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);
        }

        static void Main(string[] args)
        {
            OAuth();
           // B2C();
           // B2B();
            //C2B_Register();
          // C2B_Simulate();
           // Lipa_Na_Mpesa_Online();
            //Lipa_Na_Mpesa_Query();
            //Reversal();
            //Transcation_Status();
            //Account_Balance();
        }
    }
}

