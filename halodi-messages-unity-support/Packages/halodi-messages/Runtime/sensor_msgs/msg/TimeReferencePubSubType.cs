using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "TimeReference" defined in "TimeReference.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from TimeReference.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit TimeReference.idl instead.
*
*/
public class TimeReferencePubSubType : Halodi.CDR.TopicDataType<TimeReference>
{
   public override string Name => "sensor_msgs::msg::dds_::TimeReference_";


   public static int getCdrSerializedSize(sensor_msgs.msg.TimeReference data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.TimeReference data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += builtin_interfaces.msg.TimePubSubType.getCdrSerializedSize(data.time_ref, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.timeSource.Length + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.TimeReference data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      builtin_interfaces.msg.TimePubSubType.write(data.time_ref, cdr);

      cdr.write_type_d(data.timeSource);

   }

   public static void read(sensor_msgs.msg.TimeReference data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.time_ref = builtin_interfaces.msg.TimePubSubType.Create();
      builtin_interfaces.msg.TimePubSubType.read(data.time_ref, cdr);
      	
      data.timeSource = cdr.read_type_d();	

   }


	public override void Serialize(sensor_msgs.msg.TimeReference data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(sensor_msgs.msg.TimeReference data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(sensor_msgs.msg.TimeReference data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(sensor_msgs.msg.TimeReference src, sensor_msgs.msg.TimeReference target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(sensor_msgs.msg.TimeReference src, sensor_msgs.msg.TimeReference target)
    {
    	Copy(src, target);
    }


}


}