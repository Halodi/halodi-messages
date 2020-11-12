using System.Text;
namespace visualization_msgs.msg
{


/**
       * See:
       * - http://www.ros.org/wiki/rviz/DisplayTypes/Marker
       * - http://www.ros.org/wiki/rviz/Tutorials/Markers%3A%20Basic%20Shapes
       * 
       * for more information on using this message with rviz.
       */
[System.Serializable]
public class Marker
{
   public const byte ARROW = (byte) 0;
   public const byte CUBE = (byte) 1;
   public const byte SPHERE = (byte) 2;
   public const byte CYLINDER = (byte) 3;
   public const byte LINE_STRIP = (byte) 4;
   public const byte LINE_LIST = (byte) 5;
   public const byte CUBE_LIST = (byte) 6;
   public const byte SPHERE_LIST = (byte) 7;
   public const byte POINTS = (byte) 8;
   public const byte TEXT_VIEW_FACING = (byte) 9;
   public const byte MESH_RESOURCE = (byte) 10;
   public const byte TRIANGLE_LIST = (byte) 11;
   public const byte ADD = (byte) 0;
   public const byte MODIFY = (byte) 0;
   public const byte DELETE = (byte) 2;
   public const byte DELETEALL = (byte) 3;
   /**
            * Header for timestamp and frame id.
            */
   public std_msgs.msg.Header header;
   /**
            * Namespace in which to place the object.
            * Used in conjunction with id to create a unique name for the object.
            */
   public string ns;
   /**
            * Object ID used in conjunction with the namespace for manipulating and deleting the object later.
            */
   public int id;
   /**
            * Type of object.
            */
   public int type;
   /**
            * Action to take; one of:
            * - 0 add/modify an object
            * - 1 (deprecated)
            * - 2 deletes an object
            * - 3 deletes all objects
            */
   public int action;
   /**
            * Pose of the object with respect the frame_id specified in the header.
            */
   public geometry_msgs.msg.Pose pose;
   /**
            * Scale of the object; 1,1,1 means default (usually 1 meter square).
            */
   public geometry_msgs.msg.Vector3 scale;
   /**
            * Color of the object; in the range: [0.0-1.0]
            */
   public std_msgs.msg.ColorRGBA color;
   /**
            * How long the object should last before being automatically deleted.
            * 0 indicates forever.
            */
   public builtin_interfaces.msg.Duration lifetime;
   /**
            * If this marker should be frame-locked, i.e. retransformed into its frame every timestep.
            */
   public bool frame_locked;
   /**
            * Only used if the type specified has some use for them (eg. POINTS, LINE_STRIP, etc.)
            */
   public System.Collections.Generic.List<geometry_msgs.msg.Point> points;
   /**
            * Only used if the type specified has some use for them (eg. POINTS, LINE_STRIP, etc.)
            * The number of colors provided must either be 0 or equal to the number of points provided.
            * NOTE: alpha is not yet used
            */
   public System.Collections.Generic.List<std_msgs.msg.ColorRGBA> colors;
   /**
            * Only used for text markers
            */
   public string text;
   /**
            * Only used for MESH_RESOURCE markers.
            */
   public string mesh_resource;
   public bool mesh_use_embedded_materials;


   public void Set(Marker other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      ns = other.ns;

      id = other.id;

      type = other.type;

      action = other.action;

      geometry_msgs.msg.PosePubSubType.Copy(other.pose, pose);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.scale, scale);

      std_msgs.msg.ColorRGBAPubSubType.Copy(other.color, color);

      builtin_interfaces.msg.DurationPubSubType.Copy(other.lifetime, lifetime);

      frame_locked = other.frame_locked;


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

      if(other.colors == null)
      {
      	colors = null;
      }
      else
      {
      	colors = new System.Collections.Generic.List<std_msgs.msg.ColorRGBA>(other.colors.Count);
      	for(int i2 = 0; i2 < other.colors.Count; i2++)
      	{
      		if(other.colors[i2] == null)
      		{
      			colors.Add(null);
      		}
      		else
      		{
      			std_msgs.msg.ColorRGBA newElement = std_msgs.msg.ColorRGBAPubSubType.Create();
      	   		std_msgs.msg.ColorRGBAPubSubType.Copy(other.colors[i2], newElement);
      	   		colors.Add(newElement);
      		}	}
      }
      text = other.text;

      mesh_resource = other.mesh_resource;

      mesh_use_embedded_materials = other.mesh_use_embedded_materials;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Marker {");
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
      builder.Append("pose=");
      builder.Append(this.pose);      builder.Append(", ");
      builder.Append("scale=");
      builder.Append(this.scale);      builder.Append(", ");
      builder.Append("color=");
      builder.Append(this.color);      builder.Append(", ");
      builder.Append("lifetime=");
      builder.Append(this.lifetime);      builder.Append(", ");
      builder.Append("frame_locked=");
      builder.Append(this.frame_locked);      builder.Append(", ");
      builder.Append("points=");
      builder.Append(this.points);      builder.Append(", ");
      builder.Append("colors=");
      builder.Append(this.colors);      builder.Append(", ");
      builder.Append("text=");
      builder.Append(this.text);      builder.Append(", ");
      builder.Append("mesh_resource=");
      builder.Append(this.mesh_resource);      builder.Append(", ");
      builder.Append("mesh_use_embedded_materials=");
      builder.Append(this.mesh_use_embedded_materials);
      builder.Append("}");
      return builder.ToString();
   }
}


}