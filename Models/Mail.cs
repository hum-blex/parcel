using System.ComponentModel.DataAnnotations;

namespace parcel.Models
{
	public class mail
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string From { get; set; }
		[Required]
		public string To { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
		public string AttachmentUrl { get; set; }
		public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
