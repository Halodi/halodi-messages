using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "NavSatStatus" defined in "NavSatStatus.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from NavSatStatus.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit NavSatStatus.idl instead.
*
*/
public class NavSatStatusPubSubType : Halodi.CDR.TopicDataType<NavSatStatus>
{
   public override string Name => "sensor_msgs::msg::dds_::NavSatStatus_";


   public static int getCdrSerializedSize(sensor_msgs.msg.NavSatStatus data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.NavSatStatus data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 2 + Halodi.CDR.CDRCommon.alignment(current_alignment, 2);



      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.NavSatStatus data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_9(data.status);

      cdr.write_type_3(data.service);

   }

   public static void read(sensor_msgs.msg.NavSatStatus data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.status=cdr.read_type_9();
      	
      data.service=cdr.read_type_3();
      	

   }


	public override void Serialize(sensor_msgs.msg.NavSatStatus data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(sensor_msgs.msg.NavSatStatus data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(sensor_msgs.msg.NavSatStatus data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(sensor_msgs.msg.NavSatStatus src, sensor_msgs.msg.NavSatStatus target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(sensor_msgs.msg.NavSatStatus src, sensor_msgs.msg.NavSatStatus target)
    {
    	Copy(src, target);
    }


}


}