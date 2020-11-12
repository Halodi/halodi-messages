using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class UInt16
{
   public ushort data;


   public void Set(UInt16 other)
   {
      data = other.data;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("UInt16 {");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}