// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/TrajectoryInterpolation.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__TRAJECTORY_INTERPOLATION__STRUCT_HPP_
#define HALODI_MSGS__MSG__TRAJECTORY_INTERPOLATION__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__TrajectoryInterpolation __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__TrajectoryInterpolation __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct TrajectoryInterpolation_
{
  using Type = TrajectoryInterpolation_<ContainerAllocator>;

  explicit TrajectoryInterpolation_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->value = 0;
    }
  }

  explicit TrajectoryInterpolation_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    (void)_alloc;
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->value = 0;
    }
  }

  // field types and members
  using _value_type =
    unsigned char;
  _value_type value;

  // setters for named parameter idiom
  Type & set__value(
    const unsigned char & _arg)
  {
    this->value = _arg;
    return *this;
  }

  // constant declarations
  static constexpr unsigned char LINEAR =
    0;
  static constexpr unsigned char MINIMUM_JERK_CONSTRAINED =
    1;
  static constexpr unsigned char MULTIPLE_WAYPOINT_SPLINE =
    2;

  // pointer types
  using RawPtr =
    halodi_msgs::msg::TrajectoryInterpolation_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::TrajectoryInterpolation_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::TrajectoryInterpolation_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::TrajectoryInterpolation_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::TrajectoryInterpolation_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::TrajectoryInterpolation_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::TrajectoryInterpolation_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::TrajectoryInterpolation_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::TrajectoryInterpolation_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::TrajectoryInterpolation_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__TrajectoryInterpolation
    std::shared_ptr<halodi_msgs::msg::TrajectoryInterpolation_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__TrajectoryInterpolation
    std::shared_ptr<halodi_msgs::msg::TrajectoryInterpolation_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const TrajectoryInterpolation_ & other) const
  {
    if (this->value != other.value) {
      return false;
    }
    return true;
  }
  bool operator!=(const TrajectoryInterpolation_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct TrajectoryInterpolation_

// alias to use template instance with default allocator
using TrajectoryInterpolation =
  halodi_msgs::msg::TrajectoryInterpolation_<std::allocator<void>>;

// constant definitions
template<typename ContainerAllocator>
constexpr unsigned char TrajectoryInterpolation_<ContainerAllocator>::LINEAR;
template<typename ContainerAllocator>
constexpr unsigned char TrajectoryInterpolation_<ContainerAllocator>::MINIMUM_JERK_CONSTRAINED;
template<typename ContainerAllocator>
constexpr unsigned char TrajectoryInterpolation_<ContainerAllocator>::MULTIPLE_WAYPOINT_SPLINE;

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__TRAJECTORY_INTERPOLATION__STRUCT_HPP_
