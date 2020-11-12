using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class String
{
   public string data;


   public void Set(String other)
   {
      data = other.data;
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("String {");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}