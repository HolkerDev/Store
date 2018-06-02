using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data
{
    [Table("Transaction")]
    public class Transaction
    {
        int transactionId = 0;
        int amount = 1;
        decimal price = 1M;

        [Key]
        public int TransactionId
        {
            get { return transactionId; }
            set { transactionId = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public virtual Album AlbumData { get; set; }
        public virtual Game GameData { get; set; }
        public virtual Movie MovieData { get; set; }

        [NotMapped]
        public String AlbumName
        {
            get
            {
                if(AlbumData != null)
                {
                    return AlbumData.AlbumName;
                }
                else
                {
                    return "";
                }
            }
        }
        [NotMapped]
        public String GameName
        {
            get
            {
                if (GameData != null)
                {
                    return GameData.GameName;
                }
                else
                {
                    return "";
                }
            }
        }
        [NotMapped]
        public String MovieName
        {
            get
            {
                if (MovieData != null)
                {
                    return MovieData.MovieName;
                }
                else
                {
                    return "";
                }
            }
        }
    }
}
