using System.Text;
namespace shape_msgs.msg
{


/**
       * Defines box, sphere, cylinder, and cone.
       * All shapes are defined to have their bounding boxes centered around 0,0,0.
       * The meaning of the shape dimensions: each constant defines the index in the 'dimensions' array.
       * For the CYLINDER and CONE types, the center line is oriented along the Z axis.
       * Therefore the CYLINDER_HEIGHT (CONE_HEIGHT) component of dimensions gives the
       * height of the cylinder (cone).
       * The CYLINDER_RADIUS (CONE_RADIUS) component of dimensions gives the radius of
       * the base of the cylinder (cone).
       * Cone and cylinder primitives are defined to be circular. The tip of the cone
       * is pointing up, along +Z axis.
       */
[System.Serializable]
public class SolidPrimitive : Halodi.CDR.DataType<SolidPrimitive>
{

	public Halodi.CDR.TopicDataType<SolidPrimitive> Type => new SolidPrimitivePubSubType();
	
   public const byte BOX = (byte) 1;
   public const byte SPHERE = (byte) 2;
   public const byte CYLINDER = (byte) 3;
   public const byte CONE = (byte) 4;
   /**
          * For type BOX, the X, Y, and Z dimensions are the length of the corresponding sides of the box.
          */
   public const byte BOX_X = (byte) 0;
   public const byte BOX_Y = (byte) 1;
   public const byte BOX_Z = (byte) 2;
   /**
          * For the SPHERE type, only one component is used, and it gives the radius of the sphere.
          */
   public const byte SPHERE_RADIUS = (byte) 0;
   public const byte CYLINDER_HEIGHT = (byte) 0;
   public const byte CYLINDER_RADIUS = (byte) 1;
   public const byte CONE_HEIGHT = (byte) 0;
   public const byte CONE_RADIUS = (byte) 1;
   /**
            * The type of the shape
            */
   public byte type;
   /**
            * The dimensions of the shape
            * At no point will dimensions have a length > 3.
            */
   public System.Collections.Generic.List<double> dimensions;


   public void Set(SolidPrimitive other)
   {
      type = other.type;


      if(other.dimensions == null)
      {
      	dimensions = null;
      }
      else
      {
      	dimensions = new System.Collections.Generic.List<double>(other.dimensions.Count);
      	for(int i1 = 0; i1 < other.dimensions.Count; i1++)
      	{
         		dimensions.Add(other.dimensions[i1]);
      	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("SolidPrimitive {");
      builder.Append("type=");
      builder.Append(this.type);      builder.Append(", ");
      builder.Append("dimensions=");
      builder.Append(this.dimensions);
      builder.Append("}");
      return builder.ToString();
   }
}


}