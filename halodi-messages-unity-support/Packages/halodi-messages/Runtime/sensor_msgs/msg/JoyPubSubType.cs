using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "Joy" defined in "Joy.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Joy.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Joy.idl instead.
*
*/
public class JoyPubSubType : Halodi.CDR.TopicDataType<sensor_msgs.msg.Joy>
{
   public override string Name => "sensor_msgs::msg::dds_::Joy_";


   
   public override void serialize(sensor_msgs.msg.Joy data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, sensor_msgs.msg.Joy data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.Joy data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.Joy data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.axes.Count * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.buttons.Count * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.Joy data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      	if(data.axes == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int axes_length = data.axes.Count;
            cdr.write_type_2(axes_length);
            for (int i0 = 0; i0 < axes_length; i0++)
            {
      			cdr.write_type_5(data.axes[i0]);
            }
        }
      	if(data.buttons == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int buttons_length = data.buttons.Count;
            cdr.write_type_2(buttons_length);
            for (int i0 = 0; i0 < buttons_length; i0++)
            {
      			cdr.write_type_2(data.buttons[i0]);
            }
        }
   }

   public static void read(sensor_msgs.msg.Joy data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	

      int axes_length = cdr.read_type_2();
      data.axes = new System.Collections.Generic.List<float>(axes_length);
      for(int i = 0; i < axes_length; i++)
      {
      	data.axes.Add(cdr.read_type_5());
      	
      	
      }

      	

      int buttons_length = cdr.read_type_2();
      data.buttons = new System.Collections.Generic.List<int>(buttons_length);
      for(int i = 0; i < buttons_length; i++)
      {
      	data.buttons.Add(cdr.read_type_2());
      	
      	
      }

      	

   }


    public static void Copy(sensor_msgs.msg.Joy src, sensor_msgs.msg.Joy target)
    {
        target.Set(src);
    }


}


}