using System.Text;
namespace visualization_msgs.msg
{


[System.Serializable]
public class ImageMarker : Halodi.CDR.DataType<ImageMarker>
{

	public Halodi.CDR.TopicDataType<ImageMarker> Type => new ImageMarkerPubSubType();
	
   public const byte CIRCLE = (byte) 0;
   public const byte LINE_STRIP = (byte) 1;
   public const byte LINE_LIST = (byte) 2;
   public const byte POLYGON = (byte) 3;
   public const byte POINTS = (byte) 4;
   public const byte ADD = (byte) 0;
   public const byte REMOVE = (byte) 1;
   public std_msgs.msg.Header header;
   /**
            * Namespace which is used with the id to form a unique id.
            */
   public string ns;
   /**
            * Unique id within the namespace.
            */
   public int id;
   /**
            * One of the above types, e.g. CIRCLE, LINE_STRIP, etc.
            */
   public int type;
   /**
            * Either ADD or REMOVE.
            */
   public int action;
   /**
            * Two-dimensional coordinate position, in pixel-coordinates.
            */
   public geometry_msgs.msg.Point position;
   /**
            * The scale of the object, e.g. the diameter for a CIRCLE.
            */
   public float scale;
   /**
            * The outline color of the marker.
            */
   public std_msgs.msg.ColorRGBA outline_color;
   /**
            * Whether or not to fill in the shape with color.
            */
   public byte filled;
   /**
            * Fill color; in the range: [0.0-1.0]
            */
   public std_msgs.msg.ColorRGBA fill_color;
   /**
            * How long the object should last before being automatically deleted.
            * 0 indicates forever.
            */
   public builtin_interfaces.msg.Duration lifetime;
   /**
            * Coordinates in 2D in pixel coords. Used for LINE_STRIP, LINE_LIST, POINTS, etc.
            */
   public System.Collections.Generic.List<geometry_msgs.msg.Point> points;
   /**
            * The color for each line, point, etc. in the points field.
            */
   public System.Collections.Generic.List<std_msgs.msg.ColorRGBA> outline_colors;


   public void Set(ImageMarker other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      ns = other.ns;

      id = other.id;

      type = other.type;

      action = other.action;

      geometry_msgs.msg.PointPubSubType.Copy(other.position, position);

      scale = other.scale;

      std_msgs.msg.ColorRGBAPubSubType.Copy(other.outline_color, outline_color);

      filled = other.filled;

      std_msgs.msg.ColorRGBAPubSubType.Copy(other.fill_color, fill_color);

      builtin_interfaces.msg.DurationPubSubType.Copy(other.lifetime, lifetime);


      if(other.points == null)
      {
      	points = null;
      }
      else
      {
      	points = new System.Collections.Generic.List<geometry_msgs.msg.Point>(other.points.Count);
      	for(int i1 = 0; i1 < other.points.Count; i1++)
      	{
      		if(other.points[i1] == null)
      		{
      			points.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.Point newElement = geometry_msgs.msg.PointPubSubType.Create();
      	   		geometry_msgs.msg.PointPubSubType.Copy(other.points[i1], newElement);
      	   		points.Add(newElement);
      		}	}
      }

      if(other.outline_colors == null)
      {
      	outline_colors = null;
      }
      else
      {
      	outline_colors = new System.Collections.Generic.List<std_msgs.msg.ColorRGBA>(other.outline_colors.Count);
      	for(int i2 = 0; i2 < other.outline_colors.Count; i2++)
      	{
      		if(other.outline_colors[i2] == null)
      		{
      			outline_colors.Add(null);
      		}
      		else
      		{
      			std_msgs.msg.ColorRGBA newElement = std_msgs.msg.ColorRGBAPubSubType.Create();
      	   		std_msgs.msg.ColorRGBAPubSubType.Copy(other.outline_colors[i2], newElement);
      	   		outline_colors.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ImageMarker {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("ns=");
      builder.Append(this.ns);      builder.Append(", ");
      builder.Append("id=");
      builder.Append(this.id);      builder.Append(", ");
      builder.Append("type=");
      builder.Append(this.type);      builder.Append(", ");
      builder.Append("action=");
      builder.Append(this.action);      builder.Append(", ");
      builder.Append("position=");
      builder.Append(this.position);      builder.Append(", ");
      builder.Append("scale=");
      builder.Append(this.scale);      builder.Append(", ");
      builder.Append("outline_color=");
      builder.Append(this.outline_color);      builder.Append(", ");
      builder.Append("filled=");
      builder.Append(this.filled);      builder.Append(", ");
      builder.Append("fill_color=");
      builder.Append(this.fill_color);      builder.Append(", ");
      builder.Append("lifetime=");
      builder.Append(this.lifetime);      builder.Append(", ");
      builder.Append("points=");
      builder.Append(this.points);      builder.Append(", ");
      builder.Append("outline_colors=");
      builder.Append(this.outline_colors);
      builder.Append("}");
      return builder.ToString();
   }
}


}