using System.Text;
namespace std_msgs.msg
{


[System.Serializable]
public class ColorRGBA : Halodi.CDR.DataType<ColorRGBA>
{

	public Halodi.CDR.TopicDataType<ColorRGBA> Type => new ColorRGBAPubSubType();
	
   public float r;
   public float g;
   public float b;
   public float a;


   public void Set(ColorRGBA other)
   {
      r = other.r;

      g = other.g;

      b = other.b;

      a = other.a;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ColorRGBA {");
      builder.Append("r=");
      builder.Append(this.r);      builder.Append(", ");
      builder.Append("g=");
      builder.Append(this.g);      builder.Append(", ");
      builder.Append("b=");
      builder.Append(this.b);      builder.Append(", ");
      builder.Append("a=");
      builder.Append(this.a);
      builder.Append("}");
      return builder.ToString();
   }
}


}