using DNP_AS1_CEN.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace BLI.Data.Adult
{
    public class Person {
      
        private EyeColourInterface EyeInterface = new EyeColour();
        private HairColourInterface HairColourInterface = new HairColor();
        public int Id { get; set; }
        [NotNull]
        public string FirstName { get; set; }
        public void SetFName(string FName)
        {
            FirstName = FName;
        }
        [NotNull]
        public string LastName { get; set; }
        public void SetLName(string LName)
        {
            LastName = LName;
        }
        [ValidHairColor]

        public string HairColor { get; set; }
        public void SetHairColour(int index)
        {
            HairColor = HairColourInterface.SelectHairColour(index);
        }
        [NotNull]
        [ValidEyeColor]
        public string EyeColor { get; set; }
        public void SetEyeColour(int index)
        {
            EyeColor = EyeInterface.SelectEyeColour(index);
        }
        [NotNull, Range(0, 125)]
        public int Age { get; set; }
        public void SetAge(int age)
        {
            Age = age;
        }
        [NotNull, Range(1, 250)]
        public float Weight { get; set; }
        public void setWeight(float weight)
        {
            Weight = weight;
        }
        [NotNull, Range(30, 250)]
        public int Height { get; set; }
        public void setHeight(int height)
        {
            Height = height;
        }
        [NotNull]
        public string Sex { get; set; }
        public void setSex(Boolean sex)
        {
            string sa = "";
            if (sex == true)
            {
                sa = "female";
            }
            else sa = "male";
            Sex = sa;
        }
        public Person()
        {
        }   
        public void Update(Person toUpdate) {
        Age = toUpdate.Age;
        Height = toUpdate.Height;
        HairColor = toUpdate.HairColor;
        Sex = toUpdate.Sex;
        Weight = toUpdate.Weight;
        EyeColor = toUpdate.EyeColor;
        FirstName = toUpdate.FirstName;
        LastName = toUpdate.LastName;
    }

}

public class ValidHairColor : ValidationAttribute {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
        List<string> valid = new[] {"blond", "red", "brown", "black",
            "white", "grey", "blue", "green", "leverpostej"}.ToList();
        if (valid == null || valid.Contains(value.ToString().ToLower())) {
            return ValidationResult.Success;
        }
        return new ValidationResult("Valid hair colors are: Blond, Red, Brown, Black, White, Grey, Blue, Green, Leverpostej");
    }
}

public class ValidEyeColor : ValidationAttribute {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
        List<string> valid = new[] {"brown", "grey", "green", "blue",
            "amber", "hazel"}.ToList();
        if (valid != null && valid.Contains(value.ToString().ToLower())) {
            return ValidationResult.Success;
        }
        return new ValidationResult("Valid hair colors are: Brown, Grey, Green, Blue, Amber, Hazel");
    }
}

}