using System.IO;
namespace diagnostic_msgs.msg
{

/**
* 
* Topic data type of the struct "DiagnosticArray" defined in "DiagnosticArray.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from DiagnosticArray.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit DiagnosticArray.idl instead.
*
*/
public class DiagnosticArrayPubSubType : Halodi.CDR.TopicDataType<DiagnosticArray>
{
   public override string Name => "diagnostic_msgs::msg::dds_::DiagnosticArray_";


   
   public override void serialize(diagnostic_msgs.msg.DiagnosticArray data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, diagnostic_msgs.msg.DiagnosticArray data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(diagnostic_msgs.msg.DiagnosticArray data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(diagnostic_msgs.msg.DiagnosticArray data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.status.Count; ++i0)
      {
          current_alignment += diagnostic_msgs.msg.DiagnosticStatusPubSubType.getCdrSerializedSize(data.status[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(diagnostic_msgs.msg.DiagnosticArray data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      	if(data.status == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int status_length = data.status.Count;
            cdr.write_type_2(status_length);
            for (int i0 = 0; i0 < status_length; i0++)
            {
      			diagnostic_msgs.msg.DiagnosticStatusPubSubType.write(data.status[i0], cdr);	      }
        }
   }

   public static void read(diagnostic_msgs.msg.DiagnosticArray data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	

      int status_length = cdr.read_type_2();
      data.status = new System.Collections.Generic.List<diagnostic_msgs.msg.DiagnosticStatus>(status_length);
      for(int i = 0; i < status_length; i++)
      {
      	diagnostic_msgs.msg.DiagnosticStatus new_status = diagnostic_msgs.msg.DiagnosticStatusPubSubType.Create(); 
      	diagnostic_msgs.msg.DiagnosticStatusPubSubType.read(new_status, cdr);
      	data.status.Add(new_status);	
      	
      }

      	

   }


    public static void Copy(diagnostic_msgs.msg.DiagnosticArray src, diagnostic_msgs.msg.DiagnosticArray target)
    {
        target.Set(src);
    }


}


}