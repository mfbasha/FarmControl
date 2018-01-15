namespace FarmControl.Models.Shared
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the <see cref="Document" />
    /// </summary>
    /// <code>
    /// Add code
    /// </code>
    public class Document
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Document"/> class.
        /// </summary>
        public Document()
        {
            ModfiedDate = DateTime.Now.Date;
        }

        /// <summary>
        /// Gets or sets the DocumentContent
        /// </summary>
        [Required]
        public byte[] DocumentContent { get; set; }

        /// <summary>
        /// Gets or sets the DocumentName
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string DocumentName { get; set; }

        /// <summary>
        /// Gets or sets the DocumentStatus
        /// </summary>
        [EnumDataType(typeof(DocumentStatus))]
        public DocumentStatus DocumentStatus { get; set; }

        /// <summary>
        /// Gets or sets the DocumentTitle
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string DocumentTitle { get; set; }

        /// <summary>
        /// Gets or sets the DueDate
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets the ExpiryDate
        /// </summary>
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets the FileName
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the IssueDate
        /// </summary>
        public DateTime IssueDate { get; set; }

        /// <summary>
        /// Gets the ModfiedDate
        /// </summary>
        public DateTime ModfiedDate { get; }

        /// <summary>
        /// Gets or sets the Summary
        /// </summary>
        [MaxLength(400)]
        [DataType(DataType.MultilineText)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets the ValueDate
        /// </summary>
        public DateTime ValueDate { get; set; }
    }

    /// <summary>
    /// Defines the DocumentType
    /// </summary>
    public enum DocumentType
    {
        /// <summary>
        /// Defines the Security_ID
        /// </summary>
        Security_ID,
        /// <summary>
        /// Defines the Contract
        /// </summary>
        Contract,
        /// <summary>
        /// Defines the Invoice
        /// </summary>
        Invoice,
        /// <summary>
        /// Defines the Bank_Check
        /// </summary>
        Bank_Check,
        /// <summary>
        /// Defines the Letter
        /// </summary>
        Letter,
        /// <summary>
        /// Defines the Report
        /// </summary>
        Report,
        /// <summary>
        /// Defines the Email
        /// </summary>
        Email,
        /// <summary>
        /// Defines the General
        /// </summary>
        General
    }

    /// <summary>
    /// Defines the DocumentStatus
    /// </summary>
    public enum DocumentStatus
    {
        /// <summary>
        /// Defines the Pending
        /// </summary>
        Pending,
        /// <summary>
        /// Defines the Approved
        /// </summary>
        Approved,
        /// <summary>
        /// Defines the Obsolete
        /// </summary>
        Obsolete,
        /// <summary>
        /// Defines the None
        /// </summary>
        None
    }
}
