cmake_minimum_required(VERSION 2.8.12.2)

set(CMAKE_INCLUDE_CURRENT_DIR ON)

set(TESTSOURCES
  parentProcess.cpp
)

add_executable(paltest_createprocessw_test1
  ${TESTSOURCES}
)

add_dependencies(paltest_createprocessw_test1 coreclrpal)

target_link_libraries(paltest_createprocessw_test1
  ${COMMON_TEST_LIBRARIES}
)


set(HELPERSOURCES
  childProcess.cpp
)

add_executable(paltest_createprocessw_test1_child
  ${HELPERSOURCES}
)

add_dependencies(paltest_createprocessw_test1_child coreclrpal)

target_link_libraries(paltest_createprocessw_test1_child
  ${COMMON_TEST_LIBRARIES}
)
