using System.ComponentModel.DataAnnotations;

public class Car
{
    [Required]
    public string ChasisNo { get; set; }

    [Required]
    public string CarName { get; set; }

    [Required]
    public string CompanyName { get; set; }

    [Required]
    public string CarType { get; set; }

    [Display(Name = "Email Address")]
    public string EmailAddress { get; set; }
}
