﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi.";
        public static string InvalidCarPrice = "Fiyatı 30.000 dolar üstü olan araç eklenemez.";
        public static string MaintenanceTime="Sistem şu anda bakımda.";
        public static string CarListed="Araçlar listelendi.";
        public static string CarDeleted="Araç silindi.";
        public static string CarUpdated="Araç güncellendi.";
        public static string InvalidCompanyName="Geçersiz şirket ismi. Şirket isminiz 5 karakterden uzun olmalı.";
        public static string CompanyAdded="Şirket eklendi";
        public static string CustomerDeleted;
        public static string CustomersListed="Müşteriler listelendi.";
        public static string CustomerAdded;
        public static string CustomerUpdated;
        public static string CustomerSelected;
        public static string RentalNotAdded= "Arabanın kiralanabilmesi için arabanın teslim edilmesi gerekmektedir.";
    }
}
