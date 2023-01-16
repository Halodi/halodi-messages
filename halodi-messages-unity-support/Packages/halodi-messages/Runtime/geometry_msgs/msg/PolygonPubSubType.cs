using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "Polygon" defined in "Polygon.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Polygon.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Polygon.idl instead.
*
*/
public class PolygonPubSubType : Halodi.CDR.TopicDataType<Polygon>
{
   public override string Name => "geometry_msgs::msg::dds_::Polygon_";


   public static int getCdrSerializedSize(geometry_msgs.msg.Polygon data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.Polygon data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.points.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.Point32PubSubType.getCdrSerializedSize(data.points[i0], current_alignment);}

      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.Polygon data, Halodi.CDR.CDRSerializer cdr)
   {
      	if(data.points == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int points_length = data.points.Count;
            cdr.write_type_2(points_length);
            for (int i0 = 0; i0 < points_length; i0++)
            {
      			geometry_msgs.msg.Point32PubSubType.write(data.points[i0], cdr);	      }
        }   }

   public static void read(geometry_msgs.msg.Polygon data, Halodi.CDR.CDRDeserializer cdr)
   {

      int points_length = cdr.read_type_2();
      data.points = new System.Collections.Generic.List<geometry_msgs.msg.Point32>(points_length);
      for(int i = 0; i < points_length; i++)
      {
      	geometry_msgs.msg.Point32 new_points = geometry_msgs.msg.Point32PubSubType.Create(); 
      	geometry_msgs.msg.Point32PubSubType.read(new_points, cdr);
      	data.points.Add(new_points);	
      	
      }

      	

   }


	public override void Serialize(geometry_msgs.msg.Polygon data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(geometry_msgs.msg.Polygon data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(geometry_msgs.msg.Polygon data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(geometry_msgs.msg.Polygon src, geometry_msgs.msg.Polygon target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(geometry_msgs.msg.Polygon src, geometry_msgs.msg.Polygon target)
    {
    	Copy(src, target);
    }


}


}