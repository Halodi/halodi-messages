using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "JoyFeedbackArray" defined in "JoyFeedbackArray.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from JoyFeedbackArray.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit JoyFeedbackArray.idl instead.
*
*/
public class JoyFeedbackArrayPubSubType : Halodi.CDR.TopicDataType<JoyFeedbackArray>
{
   public override string Name => "sensor_msgs::msg::dds_::JoyFeedbackArray_";


   public static int getCdrSerializedSize(sensor_msgs.msg.JoyFeedbackArray data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.JoyFeedbackArray data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.array.Count; ++i0)
      {
          current_alignment += sensor_msgs.msg.JoyFeedbackPubSubType.getCdrSerializedSize(data.array[i0], current_alignment);}

      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.JoyFeedbackArray data, Halodi.CDR.CDRSerializer cdr)
   {
      	if(data.array == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int array_length = data.array.Count;
            cdr.write_type_2(array_length);
            for (int i0 = 0; i0 < array_length; i0++)
            {
      			sensor_msgs.msg.JoyFeedbackPubSubType.write(data.array[i0], cdr);	      }
        }   }

   public static void read(sensor_msgs.msg.JoyFeedbackArray data, Halodi.CDR.CDRDeserializer cdr)
   {

      int array_length = cdr.read_type_2();
      data.array = new System.Collections.Generic.List<sensor_msgs.msg.JoyFeedback>(array_length);
      for(int i = 0; i < array_length; i++)
      {
      	sensor_msgs.msg.JoyFeedback new_array = sensor_msgs.msg.JoyFeedbackPubSubType.Create(); 
      	sensor_msgs.msg.JoyFeedbackPubSubType.read(new_array, cdr);
      	data.array.Add(new_array);	
      	
      }

      	

   }


	public override void Serialize(sensor_msgs.msg.JoyFeedbackArray data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(sensor_msgs.msg.JoyFeedbackArray data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(sensor_msgs.msg.JoyFeedbackArray data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(sensor_msgs.msg.JoyFeedbackArray src, sensor_msgs.msg.JoyFeedbackArray target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(sensor_msgs.msg.JoyFeedbackArray src, sensor_msgs.msg.JoyFeedbackArray target)
    {
    	Copy(src, target);
    }


}


}