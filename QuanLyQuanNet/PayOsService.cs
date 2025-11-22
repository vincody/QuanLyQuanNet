using System;
using System.Collections.Generic;
using System.Configuration; // Để đọc App.config
using System.Threading.Tasks;
// ✅ UPDATE V2: Namespace mới
using PayOS;
using PayOS.Models.V2.PaymentRequests;

namespace QuanLyQuanNet
{
    public static class PayOsService
    {
        // ✅ UPDATE V2: Đổi tên class từ PayOS thành PayOSClient
        private static PayOSClient payOSClient;

        static PayOsService()
        {
            string clientId = ConfigurationManager.AppSettings["PayOsClientId"];
            string apiKey = ConfigurationManager.AppSettings["PayOsApiKey"];
            string checksumKey = ConfigurationManager.AppSettings["PayOsChecksumKey"];

            // ✅ UPDATE V2: Khởi tạo PayOSClient
            payOSClient = new PayOSClient(clientId, apiKey, checksumKey);
        }

        /// <summary>
        /// Tạo link thanh toán (V2)
        /// </summary>
        public static async Task<CreatePaymentLinkResponse> CreatePaymentLink(int amount, string description, string buyerName)
        {
            long orderCode = long.Parse(DateTime.Now.ToString("yyMMddHHmmss"));

            // ✅ UPDATE V2: Dùng PaymentLinkItem thay cho ItemData
            List<PaymentLinkItem> items = new List<PaymentLinkItem>
            {
                new PaymentLinkItem
                {
                    Name = "Nap tien tai khoan",
                    Price = amount,
                    Quantity = 1
                }
            };

            // ✅ UPDATE V2: Dùng CreatePaymentLinkRequest thay cho PaymentData
            CreatePaymentLinkRequest paymentData = new CreatePaymentLinkRequest
            {
                OrderCode = orderCode,
                Amount = amount,
                Description = description,
                Items = items,
                ReturnUrl = "http://localhost:3000/success",
                CancelUrl = "http://localhost:3000/cancel",
                BuyerName = buyerName
            };

            // ✅ UPDATE V2: Gọi qua PaymentRequests.CreateAsync
            // Trả về CreatePaymentLinkResponse thay vì CreatePaymentResult
            return await payOSClient.PaymentRequests.CreateAsync(paymentData);
        }

        /// <summary>
        /// Kiểm tra trạng thái đơn hàng (V2)
        /// </summary>
        public static async Task<PaymentLink> GetPaymentInfo(long orderCode)
        {
            // ✅ UPDATE V2: Gọi qua PaymentRequests.GetAsync
            // Trả về PaymentLink thay vì PaymentLinkInformation
            return await payOSClient.PaymentRequests.GetAsync(orderCode);
        }
    }
}