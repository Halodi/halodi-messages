using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "JoyFeedback" defined in "JoyFeedback.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from JoyFeedback.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit JoyFeedback.idl instead.
*
*/
public class JoyFeedbackPubSubType : Halodi.CDR.TopicDataType<JoyFeedback>
{
   public override string Name => "sensor_msgs::msg::dds_::JoyFeedback_";


   public static int getCdrSerializedSize(sensor_msgs.msg.JoyFeedback data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.JoyFeedback data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.JoyFeedback data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_9(data.type);

      cdr.write_type_9(data.id);

      cdr.write_type_5(data.intensity);

   }

   public static void read(sensor_msgs.msg.JoyFeedback data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.type=cdr.read_type_9();
      	
      data.id=cdr.read_type_9();
      	
      data.intensity=cdr.read_type_5();
      	

   }


	public override void Serialize(sensor_msgs.msg.JoyFeedback data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(sensor_msgs.msg.JoyFeedback data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(sensor_msgs.msg.JoyFeedback data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(sensor_msgs.msg.JoyFeedback src, sensor_msgs.msg.JoyFeedback target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(sensor_msgs.msg.JoyFeedback src, sensor_msgs.msg.JoyFeedback target)
    {
    	Copy(src, target);
    }


}


}