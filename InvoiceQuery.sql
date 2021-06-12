SELECT        Customers.FirstName, Customers.LastName, Customers.Cell_No, RepairLists.RepairPrice, RepairLists.Quantity, RepairLists.ItemName, Repairs.RepairTotal, Repairs.Bookon
FROM            Customers INNER JOIN
                         Repairs ON Customers.CustomerId = Repairs.CustomerId INNER JOIN
                         RepairLists ON Repairs.RepairId = RepairLists.RepairId