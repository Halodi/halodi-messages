// generated from rosidl_typesupport_introspection_c/resource/idl__type_support.c.em
// with input from halodi_msgs:srv/GetStampedTF.idl
// generated code does not contain a copyright notice

#include <stddef.h>
#include "halodi_msgs/srv/get_stamped_tf__rosidl_typesupport_introspection_c.h"
#include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
#include "rosidl_typesupport_introspection_c/field_types.h"
#include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/message_introspection.h"
#include "halodi_msgs/srv/get_stamped_tf__functions.h"
#include "halodi_msgs/srv/get_stamped_tf__struct.h"


// Include directives for member types
// Member `parent_frame`
// Member `child_frame`
#include "rosidl_generator_c/string_functions.h"

#ifdef __cplusplus
extern "C"
{
#endif

void GetStampedTF_Request__rosidl_typesupport_introspection_c__GetStampedTF_Request_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__srv__GetStampedTF_Request__init(message_memory);
}

void GetStampedTF_Request__rosidl_typesupport_introspection_c__GetStampedTF_Request_fini_function(void * message_memory)
{
  halodi_msgs__srv__GetStampedTF_Request__fini(message_memory);
}

static rosidl_typesupport_introspection_c__MessageMember GetStampedTF_Request__rosidl_typesupport_introspection_c__GetStampedTF_Request_message_member_array[3] = {
  {
    "monotonic_stamp",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__srv__GetStampedTF_Request, monotonic_stamp),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "parent_frame",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_STRING,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__srv__GetStampedTF_Request, parent_frame),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "child_frame",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_STRING,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__srv__GetStampedTF_Request, child_frame),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers GetStampedTF_Request__rosidl_typesupport_introspection_c__GetStampedTF_Request_message_members = {
  "halodi_msgs__srv",  // message namespace
  "GetStampedTF_Request",  // message name
  3,  // number of fields
  sizeof(halodi_msgs__srv__GetStampedTF_Request),
  GetStampedTF_Request__rosidl_typesupport_introspection_c__GetStampedTF_Request_message_member_array,  // message members
  GetStampedTF_Request__rosidl_typesupport_introspection_c__GetStampedTF_Request_init_function,  // function to initialize message memory (memory has to be allocated)
  GetStampedTF_Request__rosidl_typesupport_introspection_c__GetStampedTF_Request_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t GetStampedTF_Request__rosidl_typesupport_introspection_c__GetStampedTF_Request_message_type_support_handle = {
  0,
  &GetStampedTF_Request__rosidl_typesupport_introspection_c__GetStampedTF_Request_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, srv, GetStampedTF_Request)() {
  if (!GetStampedTF_Request__rosidl_typesupport_introspection_c__GetStampedTF_Request_message_type_support_handle.typesupport_identifier) {
    GetStampedTF_Request__rosidl_typesupport_introspection_c__GetStampedTF_Request_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &GetStampedTF_Request__rosidl_typesupport_introspection_c__GetStampedTF_Request_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif

// already included above
// #include <stddef.h>
// already included above
// #include "halodi_msgs/srv/get_stamped_tf__rosidl_typesupport_introspection_c.h"
// already included above
// #include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
// already included above
// #include "rosidl_typesupport_introspection_c/field_types.h"
// already included above
// #include "rosidl_typesupport_introspection_c/identifier.h"
// already included above
// #include "rosidl_typesupport_introspection_c/message_introspection.h"
// already included above
// #include "halodi_msgs/srv/get_stamped_tf__functions.h"
// already included above
// #include "halodi_msgs/srv/get_stamped_tf__struct.h"


// Include directives for member types
// Member `stf`
#include "geometry_msgs/msg/transform_stamped.h"
// Member `stf`
#include "geometry_msgs/msg/transform_stamped__rosidl_typesupport_introspection_c.h"

#ifdef __cplusplus
extern "C"
{
#endif

void GetStampedTF_Response__rosidl_typesupport_introspection_c__GetStampedTF_Response_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__srv__GetStampedTF_Response__init(message_memory);
}

void GetStampedTF_Response__rosidl_typesupport_introspection_c__GetStampedTF_Response_fini_function(void * message_memory)
{
  halodi_msgs__srv__GetStampedTF_Response__fini(message_memory);
}

static rosidl_typesupport_introspection_c__MessageMember GetStampedTF_Response__rosidl_typesupport_introspection_c__GetStampedTF_Response_message_member_array[2] = {
  {
    "ok",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__srv__GetStampedTF_Response, ok),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "stf",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__srv__GetStampedTF_Response, stf),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers GetStampedTF_Response__rosidl_typesupport_introspection_c__GetStampedTF_Response_message_members = {
  "halodi_msgs__srv",  // message namespace
  "GetStampedTF_Response",  // message name
  2,  // number of fields
  sizeof(halodi_msgs__srv__GetStampedTF_Response),
  GetStampedTF_Response__rosidl_typesupport_introspection_c__GetStampedTF_Response_message_member_array,  // message members
  GetStampedTF_Response__rosidl_typesupport_introspection_c__GetStampedTF_Response_init_function,  // function to initialize message memory (memory has to be allocated)
  GetStampedTF_Response__rosidl_typesupport_introspection_c__GetStampedTF_Response_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t GetStampedTF_Response__rosidl_typesupport_introspection_c__GetStampedTF_Response_message_type_support_handle = {
  0,
  &GetStampedTF_Response__rosidl_typesupport_introspection_c__GetStampedTF_Response_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, srv, GetStampedTF_Response)() {
  GetStampedTF_Response__rosidl_typesupport_introspection_c__GetStampedTF_Response_message_member_array[1].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, TransformStamped)();
  if (!GetStampedTF_Response__rosidl_typesupport_introspection_c__GetStampedTF_Response_message_type_support_handle.typesupport_identifier) {
    GetStampedTF_Response__rosidl_typesupport_introspection_c__GetStampedTF_Response_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &GetStampedTF_Response__rosidl_typesupport_introspection_c__GetStampedTF_Response_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif

#include "rosidl_generator_c/service_type_support_struct.h"
// already included above
// #include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
// already included above
// #include "halodi_msgs/srv/get_stamped_tf__rosidl_typesupport_introspection_c.h"
// already included above
// #include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/service_introspection.h"

// this is intentionally not const to allow initialization later to prevent an initialization race
static rosidl_typesupport_introspection_c__ServiceMembers halodi_msgs__srv__get_stamped_tf__rosidl_typesupport_introspection_c__GetStampedTF_service_members = {
  "halodi_msgs__srv",  // service namespace
  "GetStampedTF",  // service name
  // these two fields are initialized below on the first access
  NULL,  // request message
  // halodi_msgs__srv__get_stamped_tf__rosidl_typesupport_introspection_c__GetStampedTF_Request_message_type_support_handle,
  NULL  // response message
  // halodi_msgs__srv__get_stamped_tf__rosidl_typesupport_introspection_c__GetStampedTF_Response_message_type_support_handle
};

static rosidl_service_type_support_t halodi_msgs__srv__get_stamped_tf__rosidl_typesupport_introspection_c__GetStampedTF_service_type_support_handle = {
  0,
  &halodi_msgs__srv__get_stamped_tf__rosidl_typesupport_introspection_c__GetStampedTF_service_members,
  get_service_typesupport_handle_function,
};

// Forward declaration of request/response type support functions
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, srv, GetStampedTF_Request)();

const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, srv, GetStampedTF_Response)();

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_service_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__SERVICE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, srv, GetStampedTF)() {
  if (!halodi_msgs__srv__get_stamped_tf__rosidl_typesupport_introspection_c__GetStampedTF_service_type_support_handle.typesupport_identifier) {
    halodi_msgs__srv__get_stamped_tf__rosidl_typesupport_introspection_c__GetStampedTF_service_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  rosidl_typesupport_introspection_c__ServiceMembers * service_members =
    (rosidl_typesupport_introspection_c__ServiceMembers *)halodi_msgs__srv__get_stamped_tf__rosidl_typesupport_introspection_c__GetStampedTF_service_type_support_handle.data;

  if (!service_members->request_members_) {
    service_members->request_members_ =
      (const rosidl_typesupport_introspection_c__MessageMembers *)
      ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, srv, GetStampedTF_Request)()->data;
  }
  if (!service_members->response_members_) {
    service_members->response_members_ =
      (const rosidl_typesupport_introspection_c__MessageMembers *)
      ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, srv, GetStampedTF_Response)()->data;
  }

  return &halodi_msgs__srv__get_stamped_tf__rosidl_typesupport_introspection_c__GetStampedTF_service_type_support_handle;
}
