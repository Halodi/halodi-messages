using System.IO;
namespace diagnostic_msgs.msg
{

/**
* 
* Topic data type of the struct "DiagnosticStatus" defined in "DiagnosticStatus.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from DiagnosticStatus.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit DiagnosticStatus.idl instead.
*
*/
public class DiagnosticStatusPubSubType : Halodi.CDR.TopicDataType<DiagnosticStatus>
{
   public override string Name => "diagnostic_msgs::msg::dds_::DiagnosticStatus_";


   
   public override void serialize(diagnostic_msgs.msg.DiagnosticStatus data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, diagnostic_msgs.msg.DiagnosticStatus data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(diagnostic_msgs.msg.DiagnosticStatus data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(diagnostic_msgs.msg.DiagnosticStatus data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.name.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.message.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.hardware_id.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.values.Count; ++i0)
      {
          current_alignment += diagnostic_msgs.msg.KeyValuePubSubType.getCdrSerializedSize(data.values[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(diagnostic_msgs.msg.DiagnosticStatus data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_9(data.level);

      cdr.write_type_d(data.name);

      cdr.write_type_d(data.message);

      cdr.write_type_d(data.hardware_id);

      	if(data.values == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int values_length = data.values.Count;
            cdr.write_type_2(values_length);
            for (int i0 = 0; i0 < values_length; i0++)
            {
      			diagnostic_msgs.msg.KeyValuePubSubType.write(data.values[i0], cdr);	      }
        }
   }

   public static void read(diagnostic_msgs.msg.DiagnosticStatus data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.level=cdr.read_type_9();
      	
      data.name = cdr.read_type_d();	
      data.message = cdr.read_type_d();	
      data.hardware_id = cdr.read_type_d();	

      int values_length = cdr.read_type_2();
      data.values = new System.Collections.Generic.List<diagnostic_msgs.msg.KeyValue>(values_length);
      for(int i = 0; i < values_length; i++)
      {
      	diagnostic_msgs.msg.KeyValue new_values = diagnostic_msgs.msg.KeyValuePubSubType.Create(); 
      	diagnostic_msgs.msg.KeyValuePubSubType.read(new_values, cdr);
      	data.values.Add(new_values);	
      	
      }

      	

   }


    public static void Copy(diagnostic_msgs.msg.DiagnosticStatus src, diagnostic_msgs.msg.DiagnosticStatus target)
    {
        target.Set(src);
    }


}


}