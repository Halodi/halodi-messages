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
public class JoyFeedbackArrayPubSubType : Halodi.CDR.TopicDataType<sensor_msgs.msg.JoyFeedbackArray>
{
   public override string Name => "sensor_msgs::msg::dds_::JoyFeedbackArray_";


   
   public override void serialize(sensor_msgs.msg.JoyFeedbackArray data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, sensor_msgs.msg.JoyFeedbackArray data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

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


    public static void Copy(sensor_msgs.msg.JoyFeedbackArray src, sensor_msgs.msg.JoyFeedbackArray target)
    {
        target.Set(src);
    }


}


}