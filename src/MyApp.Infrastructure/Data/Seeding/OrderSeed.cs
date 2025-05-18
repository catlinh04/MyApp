using System;
using System.Collections.Generic;
using MyApp.Domain.Entities;
using MyApp.Domain.Enums;

namespace MyApp.Infrastructure.Data.Seeding
{
    public static class OrderSeed
    {
        public static readonly Order[] Data = new[]
         {
            CreateOrder(id: "c80772c6-504f-496e-9049-12a9ba8de50c", userId: "783a64e0-efd9-4a60-b05a-65ee3ddafe95", orderDate: new DateTime(2024, 8, 25, 11, 51, 37), status: OrderStatus.Shipped),
            CreateOrder(id: "117c0767-b3b1-4003-82e0-eb409af75dd1", userId: "b89f7370-5365-4c7d-96e3-9093f4d4fa06", orderDate: new DateTime(2024, 8, 6, 11, 51, 37), status: OrderStatus.Delivered),
            CreateOrder(id: "78056d58-d419-4bc4-a58f-8801f9229d14", userId: "a6c47fa6-75e9-4518-8ab9-505eed65c431", orderDate: new DateTime(2024, 5, 17, 11, 51, 37), status: OrderStatus.Cancelled),
            CreateOrder(id: "115cda6d-0928-4f5f-a7c3-479db8acdb03", userId: "ae21eba4-ff8d-434b-8727-16dc01852b11", orderDate: new DateTime(2024, 8, 28, 11, 51, 37), status: OrderStatus.Cancelled),
            CreateOrder(id: "d30676cc-efa9-4fa6-87d5-079073b6e6cf", userId: "a24fa795-f8c4-4571-89ac-d321358fbf9d", orderDate: new DateTime(2024, 7, 25, 11, 51, 37), status: OrderStatus.Processing),
            CreateOrder(id: "818d5c83-a4dd-4694-a27b-39e4bac42e98", userId: "7219f7c3-af25-43ce-adba-5be4b583d630", orderDate: new DateTime(2024, 10, 31, 11, 51, 37), status: OrderStatus.Cancelled),
            CreateOrder(id: "88c84045-3e41-4eec-90a0-e8473381e1c0", userId: "9afedf5f-8a35-42bc-993e-8084bcf297fa", orderDate: new DateTime(2024, 10, 16, 11, 51, 37), status: OrderStatus.Cancelled),
            CreateOrder(id: "5f8148f7-5a73-4d9f-b595-d8f57a470bdd", userId: "95fd1490-ee59-43d4-96a7-d1f2d39e357e", orderDate: new DateTime(2024, 8, 29, 11, 51, 37), status: OrderStatus.Pending),
            CreateOrder(id: "bbd6c865-a274-44dd-b611-4a64afaf721a", userId: "c2fc62f9-a4b3-46b7-9e27-94a335970b5b", orderDate: new DateTime(2024, 6, 18, 11, 51, 37), status: OrderStatus.Shipped),
            CreateOrder(id: "d0cf599b-a849-4a48-ba06-916ec5a4c862", userId: "2fa29e61-a73b-412f-bddd-72f6cdf8012b", orderDate: new DateTime(2024, 6, 5, 11, 51, 37), status: OrderStatus.Shipped),
            CreateOrder(id: "3e93dc11-9558-4c8b-b1a2-3648ae13a3c1", userId: "f3b97310-cfab-4471-8ea5-0ce98e3012ab", orderDate: new DateTime(2024, 7, 11, 11, 51, 37), status: OrderStatus.Pending),
            CreateOrder(id: "23421cb3-021c-4840-b0b1-b417fe77bd9c", userId: "14945575-b9b4-49e1-9850-099dcf2038f9", orderDate: new DateTime(2024, 10, 3, 11, 51, 37), status: OrderStatus.Processing),
            CreateOrder(id: "d5bc2144-1b62-43bb-9b5b-868cc15374fe", userId: "8ae5469e-2518-4c91-8212-35be54709d5b", orderDate: new DateTime(2024, 12, 13, 11, 51, 37), status: OrderStatus.Delivered),
            CreateOrder(id: "8872d3f4-b91c-4d46-8f7e-b68bc6ba88af", userId: "31d42390-f435-46ca-9174-78b45c1db5bc", orderDate: new DateTime(2024, 12, 12, 11, 51, 37), status: OrderStatus.Processing),
            CreateOrder(id: "518c3c9b-0dca-42df-a534-fb2ac28126d0", userId: "98268f47-b79f-47b9-bf10-26cc76d02975", orderDate: new DateTime(2024, 8, 19, 11, 51, 37), status: OrderStatus.Delivered),
            CreateOrder(id: "a282e324-e963-42ac-b5ca-997a30a7293e", userId: "b7432a76-11e7-46d3-a1cb-be905cda23cc", orderDate: new DateTime(2024, 11, 26, 11, 51, 37), status: OrderStatus.Processing),
            CreateOrder(id: "2e6ae35e-7b6f-4308-b14a-97e19455f423", userId: "2c180e18-cea3-4f2c-beb5-4a533506cb71", orderDate: new DateTime(2025, 1, 30, 11, 51, 37), status: OrderStatus.Cancelled),
            CreateOrder(id: "183609ec-bb41-44c9-9b99-f2c535838072", userId: "b74cae17-a6d6-4e1f-b146-b09d4ad22d70", orderDate: new DateTime(2025, 4, 2, 11, 51, 37), status: OrderStatus.Processing),
            CreateOrder(id: "60c4635b-0a1d-4dbf-9ec6-12ac4ef94d22", userId: "f86ba4e2-c8e6-403b-b0f1-e40e12bea7ef", orderDate: new DateTime(2024, 10, 22, 11, 51, 37), status: OrderStatus.Pending),
            CreateOrder(id: "b86160a0-e435-4887-906a-1a78ab0dc1e0", userId: "c2e740d3-31ef-410f-875e-ce821ab4cbf2", orderDate: new DateTime(2025, 4, 2, 11, 51, 37), status: OrderStatus.Cancelled)
        };

        private static Order CreateOrder(string id, string userId, DateTime orderDate, OrderStatus status)
        {
            return new Order
            {
                Id = Guid.Parse(id),
                UserId = Guid.Parse(userId),
                OrderDate = orderDate,
                Status = status
            };
        }
    }
}
