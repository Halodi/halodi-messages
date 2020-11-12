using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class Float32
{
   public float data;


   public void Set(Float32 other)
   {
      data = other.data;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Float32 {");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}