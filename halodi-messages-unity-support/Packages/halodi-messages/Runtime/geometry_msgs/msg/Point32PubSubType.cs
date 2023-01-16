using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "Point32" defined in "Point32.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Point32.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Point32.idl instead.
*
*/
public class Point32PubSubType : Halodi.CDR.TopicDataType<Point32>
{
   public override string Name => "geometry_msgs::msg::dds_::Point32_";


   public static int getCdrSerializedSize(geometry_msgs.msg.Point32 data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.Point32 data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.Point32 data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_5(data.x);

      cdr.write_type_5(data.y);

      cdr.write_type_5(data.z);

   }

   public static void read(geometry_msgs.msg.Point32 data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.x=cdr.read_type_5();
      	
      data.y=cdr.read_type_5();
      	
      data.z=cdr.read_type_5();
      	

   }


	public override void Serialize(geometry_msgs.msg.Point32 data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(geometry_msgs.msg.Point32 data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(geometry_msgs.msg.Point32 data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(geometry_msgs.msg.Point32 src, geometry_msgs.msg.Point32 target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(geometry_msgs.msg.Point32 src, geometry_msgs.msg.Point32 target)
    {
    	Copy(src, target);
    }


}


}