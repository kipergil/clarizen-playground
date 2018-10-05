using System;
using Ekin.Clarizen;
using Newtonsoft.Json;

namespace BBHPro.Playground.Poco.Clarizen
{
    public class Salary : EntityId
    {
        private DateTime? effectiveFrom { get; set; }
        private DateTime? effectiveTo { get; set; }

        [JsonIgnore]
        public string UsersFullName { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId SourceObject { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId DataObjectType { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_Costtype { get; set; }

        [JsonConverter(typeof(EntityIdConverter))]
        public EntityId C_ResourceCost { get; set; }
        
        public string Name { get; set; }
        public Currency C_ResourceSalary { get; set; }
        public Currency C_CostRate { get; set; }
        public Currency C_CostRateexcldORF { get; set; }
        public DateTime? C_EffectiveFrom { get { return effectiveFrom; } set { effectiveFrom = value; } }
        public DateTime? C_EffectiveTo { get { return effectiveTo; } set { effectiveTo = value;  } }
        public string C_Comments { get; set; }
        public bool? C_IsRandom { get; set; }

        public void SetSalary(double value, string currencyText, double standardOverheadRecoveryFactor, DateTime EffectiveFrom, DateTime EffectiveTo, string usersFullName, double annualHours, bool isRandom, double prorateHours = 1, string comments = "")
        {
            C_ResourceSalary = new Currency(Math.Round(value, 0), currencyText);

            double Hours = annualHours * prorateHours;

            C_CostRate = new Currency(standardOverheadRecoveryFactor == 0 ?
                                        Math.Round((value / Hours), 2) :
                                        Math.Round((value / Hours) * standardOverheadRecoveryFactor, 2),
                                        currencyText);

            C_CostRateexcldORF = new Currency(Math.Round(value / Hours, 2), currencyText);

            C_EffectiveFrom = EffectiveFrom.Date;

            C_EffectiveTo = EffectiveTo.Date;

            C_Comments = comments;

            UsersFullName = usersFullName;

            SetName();

            C_IsRandom = isRandom;
        }

        public void SetName()
        {
            string newName = string.Empty;
            if (C_Costtype != null && C_Costtype.id.Contains("/")) newName += C_Costtype.id.Substring(C_Costtype.id.LastIndexOf("/") + 1) + " ";
            if (!string.IsNullOrWhiteSpace(UsersFullName)) newName += "for " + UsersFullName + " ";
            if (C_EffectiveFrom != null) newName += ((DateTime)C_EffectiveFrom).ToString("dd/MM/yyyy") + " - ";
            if (C_EffectiveTo != null) newName += ((DateTime)C_EffectiveTo).ToString("dd/MM/yyyy");
            Name = newName;
        }

        public Salary CopyAs(EntityId newCostType)
        {
            Salary newSalary = new Salary();
            newSalary.SourceObject = SourceObject;
            newSalary.DataObjectType = new EntityId(DataObjectType.id);
            newSalary.C_Costtype = newCostType;
            newSalary.C_ResourceCost = new EntityId(C_ResourceCost.id);
            newSalary.C_ResourceSalary = new Currency(C_ResourceSalary.value, C_ResourceSalary.currency);
            newSalary.C_EffectiveFrom = C_EffectiveFrom;
            newSalary.C_EffectiveTo = C_EffectiveTo;
            newSalary.C_Comments = C_Comments;
            newSalary.C_CostRate = new Currency(C_CostRate.value, C_CostRate.currency);
            newSalary.C_CostRateexcldORF = new Currency(C_CostRateexcldORF.value, C_CostRateexcldORF.currency);
            newSalary.UsersFullName = UsersFullName;
            newSalary.SetName();
            return newSalary;
        }

    }
}
