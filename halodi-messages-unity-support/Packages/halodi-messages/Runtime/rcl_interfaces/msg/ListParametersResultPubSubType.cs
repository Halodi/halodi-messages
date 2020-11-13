using System.IO;
namespace rcl_interfaces.msg
{

/**
* 
* Topic data type of the struct "ListParametersResult" defined in "ListParametersResult.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ListParametersResult.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ListParametersResult.idl instead.
*
*/
public class ListParametersResultPubSubType : Halodi.CDR.TopicDataType<ListParametersResult>
{
   public override string Name => "rcl_interfaces::msg::dds_::ListParametersResult_";


   
   public override void serialize(rcl_interfaces.msg.ListParametersResult data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, rcl_interfaces.msg.ListParametersResult data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.ListParametersResult data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.ListParametersResult data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.names.Count; ++i0)
      {
          current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.names[i0].Length + 1;
      }
      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.prefixes.Count; ++i0)
      {
          current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.prefixes[i0].Length + 1;
      }

      return current_alignment - initial_alignment;
   }

   public static void write(rcl_interfaces.msg.ListParametersResult data, Halodi.CDR.CDRSerializer cdr)
   {
      	if(data.names == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int names_length = data.names.Count;
            cdr.write_type_2(names_length);
            for (int i0 = 0; i0 < names_length; i0++)
            {
      			cdr.write_type_d(data.names[i0]);
            }
        }
      	if(data.prefixes == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int prefixes_length = data.prefixes.Count;
            cdr.write_type_2(prefixes_length);
            for (int i0 = 0; i0 < prefixes_length; i0++)
            {
      			cdr.write_type_d(data.prefixes[i0]);
            }
        }
   }

   public static void read(rcl_interfaces.msg.ListParametersResult data, Halodi.CDR.CDRDeserializer cdr)
   {

      int names_length = cdr.read_type_2();
      data.names = new System.Collections.Generic.List<string>(names_length);
      for(int i = 0; i < names_length; i++)
      {
      	data.names.Add(cdr.read_type_d());	
      	
      }

      	

      int prefixes_length = cdr.read_type_2();
      data.prefixes = new System.Collections.Generic.List<string>(prefixes_length);
      for(int i = 0; i < prefixes_length; i++)
      {
      	data.prefixes.Add(cdr.read_type_d());	
      	
      }

      	

   }


    public static void Copy(rcl_interfaces.msg.ListParametersResult src, rcl_interfaces.msg.ListParametersResult target)
    {
        target.Set(src);
    }


}


}