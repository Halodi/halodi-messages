using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class Float64
{
   public double data;


   public void Set(Float64 other)
   {
      data = other.data;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Float64 {");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}