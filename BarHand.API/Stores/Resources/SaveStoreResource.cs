﻿using System.ComponentModel.DataAnnotations;

namespace BarHand.API.Stores.Resources;

public class SaveStoreResource
{
    [Required]
    [MaxLength(200)]
    public string StoreName { get; set; }
    [Required]
    [MaxLength(200)]
    public string Email { get; set; }
    [Required]
    [MaxLength(200)]
    public string Address { get; set; }
    [Required]
    [MaxLength(200)]
    public string Name { get; set; }
    [Required]  
    [MaxLength(200)]
    public string LastName { get; set; }
    [Required] 
    public long Phone { get; set; }
    [Required]
    [MaxLength(200)]
    public string Password { get; set; }
    [Required]
    [MaxLength(200)]
    public string Image { get; set; }
}