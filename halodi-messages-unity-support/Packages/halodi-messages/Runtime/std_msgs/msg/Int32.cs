using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class Int32
{
   public int data;


   public void Set(Int32 other)
   {
      data = other.data;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Int32 {");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}