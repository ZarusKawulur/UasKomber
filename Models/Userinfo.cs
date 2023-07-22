using System.Security.Cryptography.X509Certificates;

namespace UasKomber.Models;

public class Userinfo 

{
	public int UserId { get; set; }
	public string Username { get; set; }

	public string Password { get; set; }
}