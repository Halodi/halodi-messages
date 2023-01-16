using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "Point" defined in "Point.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Point.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Point.idl instead.
*
*/
public class PointPubSubType : Halodi.CDR.TopicDataType<Point>
{
   public override string Name => "geometry_msgs::msg::dds_::Point_";


   public static int getCdrSerializedSize(geometry_msgs.msg.Point data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.Point data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.Point data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_6(data.x);

      cdr.write_type_6(data.y);

      cdr.write_type_6(data.z);

   }

   public static void read(geometry_msgs.msg.Point data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.x=cdr.read_type_6();
      	
      data.y=cdr.read_type_6();
      	
      data.z=cdr.read_type_6();
      	

   }


	public override void Serialize(geometry_msgs.msg.Point data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(geometry_msgs.msg.Point data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(geometry_msgs.msg.Point data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(geometry_msgs.msg.Point src, geometry_msgs.msg.Point target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(geometry_msgs.msg.Point src, geometry_msgs.msg.Point target)
    {
    	Copy(src, target);
    }


}


}