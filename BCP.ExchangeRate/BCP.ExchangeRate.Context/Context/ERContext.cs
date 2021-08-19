﻿using BCP.ExchangeRate.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BCP.ExchangeRate.Persistence.Context
{
    public class ERContext : DbContext
    {
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Rate> Rates { get; set; }

        public ERContext(DbContextOptions<ERContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Currency>().HasData(
                new Currency { Id = new Guid("e38e6fa4-6029-4fc9-93de-fccb279cfb73"), Code = "AED", Name = "United Arab Emirates Dirham", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("23bfc453-358f-41d9-ae18-be93a19849c9"), Code = "AFN", Name = "Afghanistan Afghani", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("c314ca7f-accc-43ff-82b6-2ed14f6a027c"), Code = "ALL", Name = "Albania Lek", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("594bc981-16a1-4808-bcd9-a39252f175df"), Code = "AMD", Name = "Armenia Dram", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("96fd768b-e0c2-4fc2-8ada-1a4b8d103839"), Code = "ANG", Name = "Netherlands Antilles Guilder", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("0ea9f248-8a57-4b1b-ba57-57ad9eb14336"), Code = "AOA", Name = "Angola Kwanza", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("40192f48-ab44-4b6e-a594-7d60169b6493"), Code = "ARS", Name = "Argentina Peso", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("abe46b7b-1fb5-46ca-b14c-aad820eb4369"), Code = "AUD", Name = "Australia Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("c86932ad-e4b4-478f-8fec-54e95e7407e2"), Code = "AWG", Name = "Aruba Guilder", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("fb96b687-7d24-4b59-8159-827756302717"), Code = "AZN", Name = "Azerbaijan New Manat", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("8cafac25-5c65-4797-9687-9f8c1b017187"), Code = "BAM", Name = "Bosnia and Herzegovina Convertible Marka", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("744552b0-5a48-4853-b61a-3baaede775cd"), Code = "BBD", Name = "Barbados Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("81b2262d-3be2-4c8e-9aae-ac35687ee04f"), Code = "BDT", Name = "Bangladesh Taka", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("ceec5715-8814-4295-ba04-3fe37b85bfef"), Code = "BGN", Name = "Bulgaria Lev", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("1c025208-0c66-44be-9ce4-5e79058b7503"), Code = "BHD", Name = "Bahrain Dinar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("a74ce561-def3-486a-b3a0-890cbef6ec7b"), Code = "BIF", Name = "Burundi Franc", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("5504f8c6-c153-44d7-a344-e62bbd9c3950"), Code = "BMD", Name = "Bermuda Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("2c89cd71-ca14-465a-a80b-3c6fe7744d29"), Code = "BND", Name = "Brunei Darussalam Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("6c747863-64e9-400a-af6a-af10180d5e1b"), Code = "BOB", Name = "Bolivia Boliviano", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("cc866dde-894f-4c4a-8480-8ade8a55865b"), Code = "BRL", Name = "Brazil Real", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("049c4d90-e15b-4a66-9727-83bdc041d10a"), Code = "BSD", Name = "Bahamas Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("f188a066-60ee-49d0-9404-f301fa49930e"), Code = "BTN", Name = "Bhutan Ngultrum", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("3a46f282-7e04-4d5a-ac16-47c3ab32e019"), Code = "BWP", Name = "Botswana Pula", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("a24fff75-0557-45b4-b875-a85774bc4aff"), Code = "BYR", Name = "Belarus Ruble", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("a20c3640-8261-45d9-a905-2b0a78b67458"), Code = "BZD", Name = "Belize Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("a20c3640-8261-45d9-a905-2b0a78b67459"), Code = "CAD", Name = "Canada Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("bbc160b4-42e5-46ff-9751-5622ec7aa58c"), Code = "CDF", Name = "Congo/Kinshasa Franc", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("9f9d1e67-570d-4972-9c38-c7be6032704e"), Code = "CHF", Name = "Switzerland Franc", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("24768ae0-b86a-4b14-b667-c2d7ea59911b"), Code = "CLP", Name = "Chile Peso", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("6206557a-9fe1-4a10-8bf5-9129646ed15e"), Code = "CNY", Name = "China Yuan Renminbi", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("0820014d-d21a-4259-96cc-a44c3bf7e501"), Code = "COP", Name = "Colombia Peso", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("9b0bd48d-5941-42c0-ae37-5d7c6a348ebf"), Code = "CRC", Name = "Costa Rica Colon", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("243152c4-b077-4bad-9c7f-8e05918fba53"), Code = "CUC", Name = "Cuba Convertible Peso", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("2197f72a-f977-4549-af50-33813e963152"), Code = "CUP", Name = "Cuba Peso", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("a2b20049-7aba-4077-9d70-66d7de922db9"), Code = "CVE", Name = "Cape Verde Escudo", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("f73cb084-e46e-485f-9e2d-4f0125f325ba"), Code = "CZK", Name = "Czech Republic Koruna", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("bd141e8d-9e78-4be0-aa27-4ac5c2f86a0a"), Code = "DJF", Name = "Djibouti Franc", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("d807033b-5e02-4e6e-bcae-8af21f6d72b1"), Code = "DKK", Name = "Denmark Krone", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("52f13dde-c60e-4f3f-9802-0f4aac793e84"), Code = "DOP", Name = "Dominican Republic Peso", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("3d752131-8774-4bf1-82f5-9910ad0eef6d"), Code = "DZD", Name = "Algeria Dinar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("082db4ad-ecef-4cb8-97e8-dcc3ab6d4460"), Code = "EGP", Name = "Egypt Pound", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("3f4d447a-d1bb-4a21-9d16-72e68b4c1651"), Code = "ERN", Name = "Eritrea Nakfa", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("6ad85a84-9f40-4ada-bdad-c286c38b5086"), Code = "ETB", Name = "Ethiopia Birr", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("cccfe221-3b59-405e-a0a6-91d89eb5eb32"), Code = "EUR", Name = "Euro Member Countries", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("acda604e-a292-4313-bc4d-a6310d8dc705"), Code = "FJD", Name = "Fiji Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("a1fbfbbe-6dcd-480c-81d9-d8cbaee085d7"), Code = "FKP", Name = "Falkland Islands (Malvinas) Pound", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("3b17322a-1ebd-4141-a9bb-623425114280"), Code = "GBP", Name = "United Kingdom Pound", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("703c9a82-121e-43a8-9675-4da7394c2a98"), Code = "GEL", Name = "Georgia Lari", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("3eefc192-1b8c-4dd7-ac7b-df02cf59b5f8"), Code = "GGP", Name = "Guernsey Pound", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("094c8ac8-e609-4fb2-9c20-7faf8fd11577"), Code = "GHS", Name = "Ghana Cedi", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("ce665137-742d-4981-83d8-8dbd33fcc415"), Code = "GIP", Name = "Gibraltar Pound", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("a9a01130-df61-42c0-bb94-01e78245ca59"), Code = "GMD", Name = "Gambia Dalasi", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("a1824417-b8b6-4850-9914-b9e6c301751f"), Code = "GNF", Name = "Guinea Franc", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("891d8b90-4072-4a2b-a48b-b3bfca704479"), Code = "GTQ", Name = "Guatemala Quetzal", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("9a6a464f-4319-4285-9889-3c628695e233"), Code = "GYD", Name = "Guyana Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("fe6bd8ba-c63f-4445-860a-46aa67485aa5"), Code = "HKD", Name = "Hong Kong Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("78a1e14b-11d1-4ae5-9671-b0266d62ef66"), Code = "HNL", Name = "Honduras Lempira", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("13acb188-2692-452d-a844-3e261007a850"), Code = "HRK", Name = "Croatia Kuna", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("32e1a992-90d4-4df4-92eb-4e2cf7f74335"), Code = "HTG", Name = "Haiti Gourde", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("f531bcb4-5d09-4d5a-88d0-25ca99cd8e16"), Code = "HUF", Name = "Hungary Forint", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("741c5569-6d2e-4386-be9b-f0f507ebae47"), Code = "IDR", Name = "Indonesia Rupiah", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("cb1c0998-b7d3-48aa-a25c-c3c23ff52466"), Code = "ILS", Name = "Israel Shekel", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("83f7dd0b-7049-438e-8222-54d3831668e5"), Code = "IMP", Name = "Isle of Man Pound", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("f428c395-5ff3-470b-b978-44933d226662"), Code = "INR", Name = "India Rupee", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("d2e3d478-c72d-4f35-a59a-1556e9103865"), Code = "IQD", Name = "Iraq Dinar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("aac49b24-6b91-4949-8b1a-fe161a819dd3"), Code = "IRR", Name = "Iran Rial", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("80b53b84-cc83-4c93-bc55-2ab2fb253e2c"), Code = "ISK", Name = "Iceland Krona", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("77843c65-fe24-4561-8647-d3c90814ba80"), Code = "JEP", Name = "Jersey Pound", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("e78dd993-da9e-416c-b6d0-31c1f739e855"), Code = "JMD", Name = "Jamaica Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("96f2e098-e205-4f5d-930f-c214e0591d19"), Code = "JOD", Name = "Jordan Dinar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("a5e4f029-21bf-4f93-9f44-e191bd0ce46d"), Code = "JPY", Name = "Japan Yen", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("7b71d5df-00b1-4371-b56b-ce9d240677df"), Code = "KES", Name = "Kenya Shilling", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("e1465875-d319-422c-94d4-6f32aba3d80f"), Code = "KGS", Name = "Kyrgyzstan Som", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("25e3b1a4-e71c-478b-88ef-7a7db9905602"), Code = "KHR", Name = "Cambodia Riel", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("92b3eda9-3fcb-4323-84d8-e1e72f5ed253"), Code = "KMF", Name = "Comoros Franc", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("9f555f03-568a-4c4f-a542-b84fce64e7ec"), Code = "KPW", Name = "Korea (North) Won", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("8031fe53-22b2-42ec-9944-ddad159e9c18"), Code = "KRW", Name = "Korea (South) Won", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("671c7fb1-9c9e-4cb6-99e3-a8f8de7ddad4"), Code = "KWD", Name = "Kuwait Dinar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("6afd7a4f-1ebe-46a9-9e54-36a8e0f1e7c1"), Code = "KYD", Name = "Cayman Islands Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("341bc7c8-5b28-4c09-a3e0-572db8ac8626"), Code = "KZT", Name = "Kazakhstan Tenge", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("191a0fbb-5e6c-4918-bd2e-90bdcb0f32c7"), Code = "LAK", Name = "Laos Kip", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("43faf9b0-87b0-4e0e-b6e4-749f90d6d4c4"), Code = "LBP", Name = "Lebanon Pound", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("956e837f-2110-4a4c-bd15-d378cd3927c4"), Code = "LKR", Name = "Sri Lanka Rupee", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("99ae66b8-a6ec-46c9-a4ff-c9e641957a7e"), Code = "LRD", Name = "Liberia Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("4263deb6-ebaf-4af5-baa3-3a999ec9246c"), Code = "LSL", Name = "Lesotho Loti", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("45515e1d-3b9d-475e-9c96-ffe60f18981e"), Code = "LYD", Name = "Libya Dinar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("cfc4f19d-df84-4694-9861-cfd1152ad333"), Code = "MAD", Name = "Morocco Dirham", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("3ac67d8d-78d4-470a-8212-a8528d59febf"), Code = "MDL", Name = "Moldova Leu", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("79d7e5ec-8831-4085-b358-73ff85379bd4"), Code = "MGA", Name = "Madagascar Ariary", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("1d277aeb-24f7-44d7-a059-084acda195b7"), Code = "MKD", Name = "Macedonia Denar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("88d3e10a-9da7-4a54-8298-9ac916e5ffb9"), Code = "MMK", Name = "Myanmar (Burma) Kyat", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("ded2e2dd-3e3b-4ce7-882a-adbcba909b58"), Code = "MNT", Name = "Mongolia Tughrik", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("ec32a1e0-d50a-4202-a8e2-e1df1a2ae867"), Code = "MOP", Name = "Macau Pataca", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("3599d991-46b2-4e31-9b1e-92a3025333c0"), Code = "MRO", Name = "Mauritania Ouguiya", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("35739739-4b62-4458-9862-44ab50ab72d2"), Code = "MUR", Name = "Mauritius Rupee", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("75e5545e-904a-440c-82c6-8e3e4b4f9ff9"), Code = "MVR", Name = "Maldives (Maldive Islands) Rufiyaa", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("7805b46c-b4dc-4748-9f9f-b61d793c395a"), Code = "MWK", Name = "Malawi Kwacha", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("6e095e87-1e18-48fb-ac82-5a481fb3a056"), Code = "MXN", Name = "Mexico Peso", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("432fc0d5-fd66-4068-b664-a2648b3af51f"), Code = "MYR", Name = "Malaysia Ringgit", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("2baaa945-ffa2-4e38-ad36-134c3ed4bc4f"), Code = "MZN", Name = "Mozambique Metical", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("edfa0464-7032-4f51-82df-73fd8c71480b"), Code = "NAD", Name = "Namibia Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("500b4c8d-5f7c-4ba8-846f-d75f55286103"), Code = "NGN", Name = "Nigeria Naira", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("20c3bffe-f530-43c3-8f7d-26c49004b4af"), Code = "NIO", Name = "Nicaragua Cordoba", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("a021b78b-43b5-4803-a781-c62959045235"), Code = "NOK", Name = "Norway Krone", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("b6c023d9-4378-4cd0-8caa-521c7ce84b78"), Code = "NPR", Name = "Nepal Rupee", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("f6bae376-4cdf-4b47-aa37-cb2de928d185"), Code = "NZD", Name = "New Zealand Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("93a095db-72a0-49d8-9733-3857ab8e829b"), Code = "OMR", Name = "Oman Rial", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("70fb412e-abcb-4692-b520-868673459d69"), Code = "PAB", Name = "Panama Balboa", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("9afa9661-71fd-4901-b971-a6d0ef9628df"), Code = "PEN", Name = "Peru Nuevo Sol", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("66fb31bb-5ca2-44e6-ab6d-ed956534462a"), Code = "PGK", Name = "Papua New Guinea Kina", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("d8936276-1f89-43d8-9340-921b851644c0"), Code = "PHP", Name = "Philippines Peso", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("6a60814b-78e4-45b8-9931-986ff356c19f"), Code = "PKR", Name = "Pakistan Rupee", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("d096bd51-4325-4d91-8511-981749a376a1"), Code = "PLN", Name = "Poland Zloty", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("c4f4bede-813a-49ad-9528-ef268bcdb21c"), Code = "PYG", Name = "Paraguay Guarani", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("b2ce98be-cdea-46b0-b1ea-adc8748f62f7"), Code = "QAR", Name = "Qatar Riyal", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("863651ad-7f6d-4b2c-b831-2a17b6b32676"), Code = "RON", Name = "Romania New Leu", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("cb62571d-0560-4583-b11c-ecb727d0ba49"), Code = "RSD", Name = "Serbia Dinar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("37ed2128-f882-4812-92fd-128bd4e762d5"), Code = "RUB", Name = "Russia Ruble", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("dcad406c-dd1b-4a62-abcf-4b8cc836fde0"), Code = "RWF", Name = "Rwanda Franc", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("07e681a9-e2a6-4579-a9b8-98b3b4ae339a"), Code = "SAR", Name = "Saudi Arabia Riyal", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("32ee88e9-435c-49c3-86b3-9bbf1de04f18"), Code = "SBD", Name = "Solomon Islands Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("c5c7850c-8dc2-4e72-95fb-51f047ff0fd4"), Code = "SCR", Name = "Seychelles Rupee", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("cceaba61-5015-4faf-804e-8dc993b1a5ef"), Code = "SDG", Name = "Sudan Pound", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("66f9b33d-a3bb-43bf-a5bd-d72a26605305"), Code = "SEK", Name = "Sweden Krona", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("ffdd8495-ecc4-4d0c-b496-199d932c8f93"), Code = "SGD", Name = "Singapore Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("2274bf55-c942-48b0-b553-856c07f99883"), Code = "SHP", Name = "Saint Helena Pound", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("2fea962f-b1d0-46d5-a467-ec3804e691a7"), Code = "SLL", Name = "Sierra Leone Leone", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("e8e422d9-d63a-4b3c-b91d-44edb0991650"), Code = "SOS", Name = "Somalia Shilling", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("50367d44-10f9-48fd-b88b-b1cf8137b811"), Code = "SPL", Name = "Seborga Luigino", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("c84d79bd-a177-402f-b6cb-1c9f5796c340"), Code = "SRD", Name = "Suriname Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("ca5aaa0c-190c-4c21-ac69-d353bcb90d6b"), Code = "STD", Name = "São Tomé and Príncipe Dobra", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("dd75a41f-1a4e-4cea-8725-d391ef171c78"), Code = "SVC", Name = "El Salvador Colon", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("54ac378e-744b-4c6e-9eb1-2edf710d34cd"), Code = "SYP", Name = "Syria Pound", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("57c6defc-43ba-428f-a25b-05062b05d16a"), Code = "SZL", Name = "Swaziland Lilangeni", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("91b12c9d-2f36-42ea-8516-20fecb6f1d5e"), Code = "THB", Name = "Thailand Baht", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("40f32a83-4a7f-4887-a69a-6c24493c4141"), Code = "TJS", Name = "Tajikistan Somoni", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("a4c9c552-8bc5-4676-b9f4-ab82c9d431bf"), Code = "TMT", Name = "Turkmenistan Manat", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("1aea8f61-0c10-424a-b553-bfeb12b1fc6d"), Code = "TND", Name = "Tunisia Dinar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("d12c1e67-4b79-4843-9714-03614cd9b826"), Code = "TOP", Name = "Tonga Pa'anga", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("037bf8fb-3467-4482-8a9e-be0b205e254f"), Code = "TRY", Name = "Turkey Lira", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("cb6f64a0-4ac9-4cdd-a329-16970d075e1e"), Code = "TTD", Name = "Trinidad and Tobago Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("f0adb878-e9ec-4e60-8754-20d2755ec553"), Code = "TVD", Name = "Tuvalu Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("202ac51a-cc1e-4663-a824-9379dc60ffac"), Code = "TWD", Name = "Taiwan New Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("04f88d84-688f-48e0-913d-0178ded14313"), Code = "TZS", Name = "Tanzania Shilling", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("d339b58a-617b-448f-9695-cd8945161c95"), Code = "UAH", Name = "Ukraine Hryvnia", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("b131f3b3-95c6-4727-a9e0-56daa96a9004"), Code = "UGX", Name = "Uganda Shilling", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("843a3298-6e1c-46ca-bd6e-68768d129532"), Code = "USD", Name = "United States Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("ae47deb8-bfa0-4c95-be42-2cb6c3411216"), Code = "UYU", Name = "Uruguay Peso", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("7156a889-384d-41e9-bc18-485926b73143"), Code = "UZS", Name = "Uzbekistan Som", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("59a60b92-40dd-412b-9ed4-434dd6f1df91"), Code = "VEF", Name = "Venezuela Bolivar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("82d6e10b-5151-496a-92f1-c96537ea0d06"), Code = "VND", Name = "Viet Nam Dong", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("6c08f72c-dbfe-404c-950d-5b14398ddb50"), Code = "VUV", Name = "Vanuatu Vatu", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("22348a78-1a88-4b12-81db-143ddbea0cb4"), Code = "WST", Name = "Samoa Tala", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("c55fcda9-1f44-490a-ac35-8dc6588c0f33"), Code = "XAF", Name = "Communauté Financière Africaine (BEAC) CFA Franc BEAC", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("176a3faa-954f-4d54-adc8-a58b17abbf64"), Code = "XCD", Name = "East Caribbean Dollar", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("f9af294a-7fb4-4f3f-ba3f-89f212072fd6"), Code = "XDR", Name = "International Monetary Fund (IMF) Special Drawing Rights", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("f3f30406-1f07-4f0b-97bc-40db43f63501"), Code = "XOF", Name = "Communauté Financière Africaine (BCEAO) Franc", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("a5375309-b4d5-4d77-a412-9b0e1600df2b"), Code = "XPF", Name = "Comptoirs Français du Pacifique (CFP) Franc", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("e186f227-a4e1-4f88-9f7d-bf78b898cd7a"), Code = "YER", Name = "Yemen Rial", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("49eeb26a-8119-4493-b89e-1fce66cca287"), Code = "ZAR", Name = "South Africa Rand", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("28971000-459f-4e29-9897-2fa652fa4684"), Code = "ZMW", Name = "Zambia Kwacha", CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Currency { Id = new Guid("5c6624e8-1605-436f-8500-babf5f5cebc4"), Code = "ZWD", Name = "Zimbabwe Dollar" }
            );

            modelBuilder.Entity<Rate>().HasData(
                new Rate { Id = new Guid("e38e6fa4-6029-4fc9-93de-fccb279cfb93"), AverageRate = 0.2445M, Date = DateTime.Now, EndOfDay = DateTime.Now.AddMonths(1), CurrencyId = new Guid("9afa9661-71fd-4901-b971-a6d0ef9628df"), CreatedBy = "Bruno", CreatedAt = DateTime.Now },
                new Rate { Id = new Guid("e38e6fa4-6029-4fc9-93de-fccb279cfb94"), AverageRate = 1.3704M, Date = DateTime.Now, EndOfDay = DateTime.Now.AddMonths(1), CurrencyId = new Guid("3b17322a-1ebd-4141-a9bb-623425114280"), CreatedBy = "Bruno", CreatedAt = DateTime.Now }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
