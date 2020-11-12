using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class UInt64
{
   public ulong data;


   public void Set(UInt64 other)
   {
      data = other.data;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("UInt64 {");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}