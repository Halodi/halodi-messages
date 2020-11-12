using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class Empty
{
   public bool unused_placeholder_field;


   public void Set(Empty other)
   {
      unused_placeholder_field = other.unused_placeholder_field;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Empty {");
      builder.Append("unused_placeholder_field=");
      builder.Append(this.unused_placeholder_field);
      builder.Append("}");
      return builder.ToString();
   }
}


}