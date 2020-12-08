using System.IO;
namespace rcl_interfaces.msg
{

/**
* 
* Topic data type of the struct "ParameterValue" defined in "ParameterValue.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ParameterValue.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ParameterValue.idl instead.
*
*/
public class ParameterValuePubSubType : Halodi.CDR.TopicDataType<ParameterValue>
{
   public override string Name => "rcl_interfaces::msg::dds_::ParameterValue_";


   
   public override void serialize(rcl_interfaces.msg.ParameterValue data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, rcl_interfaces.msg.ParameterValue data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.ParameterValue data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.ParameterValue data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.string_value.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.byte_array_value.Count * 1) + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.bool_array_value.Count * 1) + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.integer_array_value.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.double_array_value.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.string_array_value.Count; ++i0)
      {
          current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.string_array_value[i0].Length + 1;
      }

      return current_alignment - initial_alignment;
   }

   public static void write(rcl_interfaces.msg.ParameterValue data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_9(data.type);

      cdr.write_type_7(data.bool_value);

      cdr.write_type_11(data.integer_value);

      cdr.write_type_6(data.double_value);

      cdr.write_type_d(data.string_value);

      	if(data.byte_array_value == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int byte_array_value_length = data.byte_array_value.Count;
            cdr.write_type_2(byte_array_value_length);
            for (int i0 = 0; i0 < byte_array_value_length; i0++)
            {
      			cdr.write_type_9(data.byte_array_value[i0]);
            }
        }
      	if(data.bool_array_value == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int bool_array_value_length = data.bool_array_value.Count;
            cdr.write_type_2(bool_array_value_length);
            for (int i0 = 0; i0 < bool_array_value_length; i0++)
            {
      			cdr.write_type_7(data.bool_array_value[i0]);
            }
        }
      	if(data.integer_array_value == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int integer_array_value_length = data.integer_array_value.Count;
            cdr.write_type_2(integer_array_value_length);
            for (int i0 = 0; i0 < integer_array_value_length; i0++)
            {
      			cdr.write_type_11(data.integer_array_value[i0]);
            }
        }
      	if(data.double_array_value == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int double_array_value_length = data.double_array_value.Count;
            cdr.write_type_2(double_array_value_length);
            for (int i0 = 0; i0 < double_array_value_length; i0++)
            {
      			cdr.write_type_6(data.double_array_value[i0]);
            }
        }
      	if(data.string_array_value == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int string_array_value_length = data.string_array_value.Count;
            cdr.write_type_2(string_array_value_length);
            for (int i0 = 0; i0 < string_array_value_length; i0++)
            {
      			cdr.write_type_d(data.string_array_value[i0]);
            }
        }
   }

   public static void read(rcl_interfaces.msg.ParameterValue data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.type=cdr.read_type_9();
      	
      data.bool_value=cdr.read_type_7();
      	
      data.integer_value=cdr.read_type_11();
      	
      data.double_value=cdr.read_type_6();
      	
      data.string_value = cdr.read_type_d();	

      int byte_array_value_length = cdr.read_type_2();
      data.byte_array_value = new System.Collections.Generic.List<byte>(byte_array_value_length);
      for(int i = 0; i < byte_array_value_length; i++)
      {
      	data.byte_array_value.Add(cdr.read_type_9());
      	
      	
      }

      	

      int bool_array_value_length = cdr.read_type_2();
      data.bool_array_value = new System.Collections.Generic.List<bool>(bool_array_value_length);
      for(int i = 0; i < bool_array_value_length; i++)
      {
      	data.bool_array_value.Add(cdr.read_type_7());
      	
      	
      }

      	

      int integer_array_value_length = cdr.read_type_2();
      data.integer_array_value = new System.Collections.Generic.List<long>(integer_array_value_length);
      for(int i = 0; i < integer_array_value_length; i++)
      {
      	data.integer_array_value.Add(cdr.read_type_11());
      	
      	
      }

      	

      int double_array_value_length = cdr.read_type_2();
      data.double_array_value = new System.Collections.Generic.List<double>(double_array_value_length);
      for(int i = 0; i < double_array_value_length; i++)
      {
      	data.double_array_value.Add(cdr.read_type_6());
      	
      	
      }

      	

      int string_array_value_length = cdr.read_type_2();
      data.string_array_value = new System.Collections.Generic.List<string>(string_array_value_length);
      for(int i = 0; i < string_array_value_length; i++)
      {
      	data.string_array_value.Add(cdr.read_type_d());	
      	
      }

      	

   }


    public static void Copy(rcl_interfaces.msg.ParameterValue src, rcl_interfaces.msg.ParameterValue target)
    {
        target.Set(src);
    }


}


}