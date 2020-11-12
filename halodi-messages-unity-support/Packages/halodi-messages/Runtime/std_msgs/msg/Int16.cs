using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class Int16
{
   public short data;


   public void Set(Int16 other)
   {
      data = other.data;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Int16 {");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}