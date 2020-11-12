using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class MultiArrayDimension
{
   /**
            * label of given dimension
            */
   public string label;
   /**
            * size of given dimension (in type units)
            */
   public uint size;
   /**
            * stride of given dimension
            */
   public uint stride;


   public void Set(MultiArrayDimension other)
   {
      label = other.label;

      size = other.size;

      stride = other.stride;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("MultiArrayDimension {");
      builder.Append("label=");
      builder.Append(this.label);      builder.Append(", ");
      builder.Append("size=");
      builder.Append(this.size);      builder.Append(", ");
      builder.Append("stride=");
      builder.Append(this.stride);
      builder.Append("}");
      return builder.ToString();
   }
}


}